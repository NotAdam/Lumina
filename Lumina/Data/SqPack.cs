using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.IO;
using System.Threading;
using ICSharpCode.SharpZipLib.Zip.Compression;
using Lumina.Data.Structs;
using Lumina.Extensions;

namespace Lumina.Data
{
    public class SqPackInflateException : Exception
    {
        public SqPackInflateException( string message ) : base( message )
        {
        }
    }

    public class SqPack
    {
        /// <summary>
        /// Where the actual file is located on disk
        /// </summary>
        public FileInfo File { get; }

        /// <summary>
        /// Returns the name of the SqPack file
        /// </summary>
        public string Name => File.Name;

        /// <summary>
        /// Returns the full path to the SqPack file
        /// </summary>
        public string FullName => File.FullName;

        public SqPackHeader SqPackHeader { get; private set; }

        /// <summary>
        /// PC and PS4 are LE, PS3 is BE
        /// </summary>
        public bool ShouldConvertEndianness
        {
            // todo: what about reading LE files on BE device? do we even care?
            get => BitConverter.IsLittleEndian && SqPackHeader.platformId == PlatformId.PS3 ||
                   !BitConverter.IsLittleEndian && SqPackHeader.platformId != PlatformId.PS3;
        }

        public SqPack( FileInfo file )
        {
            Contract.Requires( file != null );
            Contract.Requires( file.Exists );

            if( !file.Exists )
            {
                throw new FileNotFoundException( $"SqPack file {file.FullName} could not be found." );
            }

            File = file;

            using var fs = file.OpenRead();
            using var br = new BinaryReader( fs );

            SqPackHeader = br.ReadStructure< SqPackHeader >();

            fs.Position = SqPackHeader.size;
        }

        public T ReadFile< T >( long offset ) where T : FileResource
        {
            using var fs = File.OpenRead();
            using var br = new BinaryReader( fs );
            using var ms = new MemoryStream();

            fs.Position = offset;

            var fileInfo = br.ReadStructure< SqPackFileInfo >();
            var file = Activator.CreateInstance< T >();

            // check if we need to read the extended model header or just default to the standard file header
            if( fileInfo.Type == FileType.Model )
            {
                fs.Position = offset;

                var modelFileInfo = br.ReadStructure< ModelBlock >();

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
                    throw new FileNotFoundException( $"The file located at 0x{offset:x} in dat {Name} is empty." );

                case FileType.Standard:
                    ReadStandardFile( file, fs, br, ms );
                    break;

                case FileType.Model:
                    ReadModelFile( file, fs, br, ms, LOD.ALL );
                    break;

                case FileType.Texture:
                    ReadTextureFile( file, fs, br, ms );
                    break;

                default:
                    throw new NotImplementedException( $"File Type {(UInt32)fileInfo.Type} is not implemented." );
            }

            file.Data = ms.ToArray();
            if( file.Data.Length != file.FileInfo.RawFileSize )
                Debug.WriteLine( "Read data size does not match file size." );
            file.LoadFile();

            return file;
        }

        private void ReadStandardFile( FileResource resource, FileStream fs, BinaryReader br, MemoryStream ms )
        {
            var blocks = br.ReadStructures< DatStdFileBlockInfos >( (int)resource.FileInfo.BlockCount );

            foreach( var block in blocks )
            {
                ReadFileBlock( resource.FileInfo.Offset + resource.FileInfo.HeaderSize + block.offset, fs, br, ms );
            }

            // reset position ready for reading
            ms.Position = 0;
        }

        // the resulting data from reading the model file does not match the file size... where is the rest of it?
        private unsafe void ReadModelFile( FileResource resource, FileStream fs, BinaryReader br, MemoryStream ms, LOD lod = 0 )
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
                totalBlocks += mdlBlock.m_uVertexBufferDataBlockNum[ i ];
            for( int i = 0; i < 3; i++ )
                totalBlocks += mdlBlock.m_uEdgeGeometryVertexBufferDataBlockNum[ i ];
            for( int i = 0; i < 3; i++ )
                totalBlocks += mdlBlock.m_uIndexBufferDataBlockNum[ i ];

            var compressedBlockSizes = br.ReadStructures< UInt16 >( totalBlocks );

            if( lod == LOD.ALL )
            {
                for( int i = 0; i < totalBlocks; i++ )
                {
                    ReadFileBlock( accumOffset, fs, br, ms );
                    accumOffset = (uint)( accumOffset + compressedBlockSizes[ i ] );
                }
            }
            else // todo: dunno, refactor this? hard to follow and may be unnecessary anyways
            {
                // so we don't have to accumulate block sizes during reading
                // which would result in a lot more looping than necessary
                var cumulativeBlockSizes = new List< UInt16 >();
                cumulativeBlockSizes.Add( 0 );

                for( int i = 0; i < compressedBlockSizes.Count; i++ )
                {
                    UInt16 temp = 0;
                    for( int j = i; j >= 0; j-- )
                        temp += (UInt16)compressedBlockSizes[ j ];
                    cumulativeBlockSizes.Add( temp );
                }

                int ilod = (Int32)lod;

                // load block index, block count for our lod
                List< int > extractIndices = new List< int >();
                List< int > extractBlockSizes = new List< int >();

                extractIndices.Add( mdlBlock.m_uStackDataBlockIndex );
                extractBlockSizes.Add( mdlBlock.m_uStackDataBlockNum );

                extractIndices.Add( mdlBlock.m_uRuntimeDataBlockIndex );
                extractBlockSizes.Add( mdlBlock.m_uRuntimeDataBlockNum );

                extractIndices.Add( mdlBlock.m_uVertexBufferDataBlockIndex[ ilod ] );
                extractBlockSizes.Add( mdlBlock.m_uVertexBufferDataBlockNum[ ilod ] );

                if( mdlBlock.m_bEnableEdgeGeometry )
                {
                    extractIndices.Add( mdlBlock.m_uEdgeGeometryVertexBufferDataBlockIndex[ ilod ] );
                    extractBlockSizes.Add( mdlBlock.m_uEdgeGeometryVertexBufferDataBlockNum[ ilod ] );
                }

                extractIndices.Add( mdlBlock.m_uIndexBufferDataBlockIndex[ ilod ] );
                extractBlockSizes.Add( mdlBlock.m_uIndexBufferDataBlockNum[ ilod ] );

                /*
                 * for any buffer i:
                 * - extractIndices[i] is the index which these blocks start at
                 * - extractBlockSizes[i] is the number of contiguous blocks that begin at extractIndices[i]
                 * - cumulativeBlockSizes[i] is the pre-accumulated start offset for block i
                 */
                for( int i = 0; i < extractIndices.Count; i++ )
                for( int j = 0; j < extractBlockSizes[ i ]; j++ )
                    ReadFileBlock( baseOffset + cumulativeBlockSizes[ extractIndices[ i ] + j ], fs, br, ms );
            }
        }

        private void ReadTextureFile( FileResource resource, FileStream fs, BinaryReader br, MemoryStream ms )
        {
            var blocks = br.ReadStructures< LodBlock >( (int)resource.FileInfo.BlockCount );

            // if there is a mipmap header, the comp_offset
            // will not be 0
            uint mipMapSize = blocks[ 0 ].comp_offset;
            if( mipMapSize != 0 )
            {
                long originalPos = fs.Position;

                fs.Position = resource.FileInfo.Offset + resource.FileInfo.HeaderSize;
                ms.Write( br.ReadBytes( (int)mipMapSize ) );

                fs.Position = originalPos;
            }

            // i is for texture blocks, j is 'data blocks'...
            for( byte i = 0; i < blocks.Count; i++ )
            {
                // start from comp_offset
                long runningBlockTotal = blocks[ i ].comp_offset + resource.FileInfo.Offset + resource.FileInfo.HeaderSize;
                ReadFileBlock( runningBlockTotal, fs, br, ms, true );

                for( int j = 1; j < blocks[ i ].block_count; j++ )
                {
                    runningBlockTotal += (UInt32)br.ReadInt16();
                    ReadFileBlock( runningBlockTotal, fs, br, ms, true );
                }

                // unknown
                br.ReadInt16();
            }
        }

        protected void ReadFileBlock( long offset, FileStream fs, BinaryReader br, MemoryStream dest, bool resetPosition = false )
        {
            long originalPosition = fs.Position;
            fs.Position = offset;

            var blockHeader = br.ReadStructure< DatBlockHeader >();

            // uncompressed block
            if( blockHeader.compressed_size == 32000 )
            {
                dest.Write( br.ReadBytes( (int)blockHeader.uncompressed_size ) );

                return;
            }

            var data = br.ReadBytes( (int)blockHeader.uncompressed_size );

            var inflater = new Inflater( true );

            inflater.SetInput( data );
            var bytesInflated = inflater.Inflate( data );

            if( bytesInflated == blockHeader.uncompressed_size )
            {
                dest.Write( data );
            }
            else
            {
                throw new SqPackInflateException( "Failed to inflate block, bytesInflated != blockHeader.uncompressed_size" );
            }

            if( resetPosition )
                fs.Position = originalPosition;
        }
    }
}