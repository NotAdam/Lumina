using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using Lumina.Data.Structs;
using Lumina.Extensions;

namespace Lumina.Data
{
    public class SqPackStream : IDisposable
    {
        public Stream BaseStream { get; protected set; }

        protected BinaryReader Reader { get; set; }

        public SqPackStream(Stream stream)
        {
            BaseStream = stream;
            Reader = new BinaryReader( BaseStream );
        }

        public SqPackHeader GetSqPackHeader()
        {
            BaseStream.Position = 0;

            return Reader.ReadStructure<SqPackHeader>();
        }

        public SqPackFileInfo GetFileMetadata( long offset )
        {
            BaseStream.Position = offset;

            return Reader.ReadStructure<SqPackFileInfo>();
        }

        public T ReadFile<T>( long offset ) where T : FileResource
        {
            using var ms = new MemoryStream();

            BaseStream.Position = offset;

            var fileInfo = Reader.ReadStructure<SqPackFileInfo>();
            var file = Activator.CreateInstance<T>();

            // check if we need to read the extended model header or just default to the standard file header
            if( fileInfo.Type == FileType.Model )
            {
                BaseStream.Position = offset;

                var modelFileInfo = Reader.ReadStructure<ModelBlock>();

                file.FileInfo = new LuminaFileInfo
                {
                    HeaderSize = modelFileInfo.Size,
                    Type = modelFileInfo.Type,
                    BlockCount = modelFileInfo.used_number_of_block,
                    RawFileSize = modelFileInfo.RawFileSize,
                    Offset = offset,

                    // todo: is this useful?
                    ModelBlock = modelFileInfo
                };
            }
            else
            {
                file.FileInfo = new LuminaFileInfo
                {
                    HeaderSize = fileInfo.Size,
                    Type = fileInfo.Type,
                    BlockCount = fileInfo.number_of_blocks,
                    RawFileSize = fileInfo.RawFileSize,
                    Offset = offset
                };
            }

            switch( fileInfo.Type )
            {
                case FileType.Empty:
                    throw new FileNotFoundException( $"The file located at 0x{offset:x} is empty." );

                case FileType.Standard:
                    ReadStandardFile( file, ms );
                    break;

                case FileType.Model:
                    ReadModelFile( file, ms, LOD.ALL );
                    break;

                case FileType.Texture:
                    ReadTextureFile( file, ms );
                    break;

                default:
                    throw new NotImplementedException( $"File Type {(UInt32)fileInfo.Type} is not implemented." );
            }

            file.Data = ms.ToArray();
            if( file.Data.Length != file.FileInfo.RawFileSize )
                Debug.WriteLine( "Read data size does not match file size." );

            file.FileStream = new MemoryStream( file.Data, false );
            file.Reader = new BinaryReader( file.FileStream );
            file.FileStream.Position = 0;

            file.LoadFile();

            return file;
        }

        private void ReadStandardFile( FileResource resource, MemoryStream ms )
        {
            var blocks = Reader.ReadStructures<DatStdFileBlockInfos>( (int)resource.FileInfo.BlockCount );

            foreach( var block in blocks )
            {
                ReadFileBlock( resource.FileInfo.Offset + resource.FileInfo.HeaderSize + block.offset, ms );
            }

            // reset position ready for reading
            ms.Position = 0;
        }

        // the resulting data from reading the model file does not match the file size... where is the rest of it?
        private unsafe void ReadModelFile( FileResource resource, MemoryStream ms, LOD lod = 0 )
        {
            if( lod != LOD.ALL )
                Console.WriteLine( "Please note that loading anything other than all LODs may not be accurate." );

            var mdlBlock = resource.FileInfo.ModelBlock;

            ms.Write( BitConverter.GetBytes( mdlBlock.m_uVertexDeclarationNum ) );
            ms.Write( BitConverter.GetBytes( mdlBlock.m_uMaterialNum ) );
            ms.Write( new byte[64] );

            if( (Int32)lod > mdlBlock.m_uLODNum )
                throw new ArgumentException( "Requested LOD does not exist.", nameof( lod ) );

            long baseOffset = resource.FileInfo.Offset + resource.FileInfo.HeaderSize;
            long accumOffset = baseOffset;

            int totalBlocks = 0;

            // 11 types of block; 1/1/3/3/3 stack/runtime/vertex/egeo/index
            totalBlocks += mdlBlock.m_uStackDataBlockNum;
            totalBlocks += mdlBlock.m_uRuntimeDataBlockNum;

            for( int i = 0; i < 3; i++ )
                totalBlocks += mdlBlock.m_uVertexBufferDataBlockNum[i];
            for( int i = 0; i < 3; i++ )
                totalBlocks += mdlBlock.m_uEdgeGeometryVertexBufferDataBlockNum[i];
            for( int i = 0; i < 3; i++ )
                totalBlocks += mdlBlock.m_uIndexBufferDataBlockNum[i];

            var compressedBlockSizes = Reader.ReadStructures<UInt16>( totalBlocks );

            if( lod == LOD.ALL )
            {
                for( int i = 0; i < totalBlocks; i++ )
                {
                    ReadFileBlock( accumOffset, ms );
                    accumOffset = (uint)( accumOffset + compressedBlockSizes[i] );
                }
            }
            else // todo: dunno, refactor this? hard to follow and may be unnecessary anyways
            {
                // so we don't have to accumulate block sizes during reading
                // which would result in a lot more looping than necessary
                var cumulativeBlockSizes = new List<UInt16>();
                cumulativeBlockSizes.Add( 0 );

                for( int i = 0; i < compressedBlockSizes.Count; i++ )
                {
                    UInt16 temp = 0;
                    for( int j = i; j >= 0; j-- )
                        temp += (UInt16)compressedBlockSizes[j];
                    cumulativeBlockSizes.Add( temp );
                }

                int ilod = (Int32)lod;

                // load block index, block count for our lod
                List<int> extractIndices = new List<int>();
                List<int> extractBlockSizes = new List<int>();

                extractIndices.Add( mdlBlock.m_uStackDataBlockIndex );
                extractBlockSizes.Add( mdlBlock.m_uStackDataBlockNum );

                extractIndices.Add( mdlBlock.m_uRuntimeDataBlockIndex );
                extractBlockSizes.Add( mdlBlock.m_uRuntimeDataBlockNum );

                extractIndices.Add( mdlBlock.m_uVertexBufferDataBlockIndex[ilod] );
                extractBlockSizes.Add( mdlBlock.m_uVertexBufferDataBlockNum[ilod] );

                if( mdlBlock.m_bEnableEdgeGeometry )
                {
                    extractIndices.Add( mdlBlock.m_uEdgeGeometryVertexBufferDataBlockIndex[ilod] );
                    extractBlockSizes.Add( mdlBlock.m_uEdgeGeometryVertexBufferDataBlockNum[ilod] );
                }

                extractIndices.Add( mdlBlock.m_uIndexBufferDataBlockIndex[ilod] );
                extractBlockSizes.Add( mdlBlock.m_uIndexBufferDataBlockNum[ilod] );

                /*
                 * for any buffer i:
                 * - extractIndices[i] is the index which these blocks start at
                 * - extractBlockSizes[i] is the number of contiguous blocks that begin at extractIndices[i]
                 * - cumulativeBlockSizes[i] is the pre-accumulated start offset for block i
                 */
                for( int i = 0; i < extractIndices.Count; i++ )
                    for( int j = 0; j < extractBlockSizes[i]; j++ )
                        ReadFileBlock( baseOffset + cumulativeBlockSizes[extractIndices[i] + j], ms );
            }
        }

        private void ReadTextureFile( FileResource resource, MemoryStream ms )
        {
            var blocks = Reader.ReadStructures<LodBlock>( (int)resource.FileInfo.BlockCount );

            // if there is a mipmap header, the comp_offset
            // will not be 0
            uint mipMapSize = blocks[0].comp_offset;
            if( mipMapSize != 0 )
            {
                long originalPos = BaseStream.Position;

                BaseStream.Position = resource.FileInfo.Offset + resource.FileInfo.HeaderSize;
                ms.Write( Reader.ReadBytes( (int)mipMapSize ) );

                BaseStream.Position = originalPos;
            }

            // i is for texture blocks, j is 'data blocks'...
            for( byte i = 0; i < blocks.Count; i++ )
            {
                // start from comp_offset
                long runningBlockTotal = blocks[i].comp_offset + resource.FileInfo.Offset + resource.FileInfo.HeaderSize;
                ReadFileBlock( runningBlockTotal, ms, true );

                for( int j = 1; j < blocks[i].block_count; j++ )
                {
                    runningBlockTotal += (UInt32)Reader.ReadInt16();
                    ReadFileBlock( runningBlockTotal, ms, true );
                }

                // unknown
                Reader.ReadInt16();
            }
        }

        protected void ReadFileBlock( long offset, MemoryStream dest, bool resetPosition = false )
        {
            long originalPosition = BaseStream.Position;
            BaseStream.Position = offset;

            var blockHeader = Reader.ReadStructure<DatBlockHeader>();

            // uncompressed block
            if( blockHeader.compressed_size == 32000 )
            {
                dest.Write( Reader.ReadBytes( (int)blockHeader.uncompressed_size ) );
                return;
            }

            var data = Reader.ReadBytes( (int)blockHeader.uncompressed_size );

            using( var compressedStream = new MemoryStream( data ) )
            {
                using var zlibStream = new DeflateStream( compressedStream, CompressionMode.Decompress );
                zlibStream.CopyTo( dest );
                zlibStream.Close();
            }

            if( resetPosition )
                BaseStream.Position = originalPosition;
        }

        public void Dispose()
        {
            Reader?.Dispose();
        }
    }
}
