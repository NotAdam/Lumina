using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Runtime.CompilerServices;
using Lumina.Data.Structs;
using Lumina.Extensions;

namespace Lumina.Data
{
    public class SqPackStream : IDisposable
    {
        public Stream BaseStream { get; }

        protected BinaryReader Reader { get; }

        public SqPackStream( FileInfo file ) : this( file.OpenRead() )
        {
        }

        public SqPackStream( Stream stream )
        {
            BaseStream = stream;
            Reader = new BinaryReader( BaseStream );
        }

        public SqPackHeader GetSqPackHeader()
        {
            BaseStream.Position = 0;

            return Reader.ReadStructure< SqPackHeader >();
        }

        public SqPackFileInfo GetFileMetadata( long offset )
        {
            BaseStream.Position = offset;

            return Reader.ReadStructure< SqPackFileInfo >();
        }

        public T ReadFile< T >( long offset ) where T : FileResource
        {
            BaseStream.Position = offset;

            var fileInfo = Reader.ReadStructure< SqPackFileInfo >();
            var file = Activator.CreateInstance< T >();

            // check if we need to read the extended model header or just default to the standard file header
            if( fileInfo.Type == FileType.Model )
            {
                BaseStream.Position = offset;

                var modelFileInfo = Reader.ReadStructure< ModelBlock >();

                file.FileInfo = new LuminaFileInfo
                {
                    HeaderSize = modelFileInfo.Size,
                    Type = modelFileInfo.Type,
                    BlockCount = modelFileInfo.UsedNumberOfBlocks,
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
                    BlockCount = fileInfo.NumberOfBlocks,
                    RawFileSize = fileInfo.RawFileSize,
                    Offset = offset
                };
            }

            var buffer = new byte[(int)file.FileInfo.RawFileSize];
            using var ms = new MemoryStream( buffer );

            switch( fileInfo.Type )
            {
                case FileType.Empty:
                    throw new FileNotFoundException( $"The file located at 0x{offset:x} is empty." );

                case FileType.Standard:
                    ReadStandardFile( file, buffer, ms );
                    break;

                case FileType.Model:
                    ReadModelFile( file, buffer, ms );
                    break;

                case FileType.Texture:
                    ReadTextureFile( file, buffer, ms );
                    break;

                default:
                    throw new NotImplementedException( $"File Type {(UInt32)fileInfo.Type} is not implemented." );
            }

            file.Data = buffer;
            if( file.Data.Length != file.FileInfo.RawFileSize )
            {
                Debug.WriteLine( "Read data size does not match file size." );
            }

            file.FileStream = new MemoryStream( file.Data, false );
            file.Reader = new BinaryReader( file.FileStream );
            file.FileStream.Position = 0;

            file.LoadFile();

            return file;
        }

        private void ReadStandardFile( FileResource resource, byte[] buffer, MemoryStream ms )
        {
            var blocks = Reader.ReadStructures< DatStdFileBlockInfos >( (int)resource.FileInfo.BlockCount );

            foreach( var block in blocks )
            {
                ReadFileBlock( resource.FileInfo.Offset + resource.FileInfo.HeaderSize + block.Offset, ms, buffer );
            }

            // reset position ready for reading
            ms.Position = 0;
        }

        private unsafe void ReadModelFile( FileResource resource, byte[] buffer, MemoryStream ms )
        {
            var mdlBlock = resource.FileInfo.ModelBlock;
            long baseOffset = resource.FileInfo.Offset + resource.FileInfo.HeaderSize;

            // 1/1/3/3/3 stack/runtime/vertex/egeo/index
            // TODO: consider testing if this is more reliable than the Explorer method
            // of adding mdlBlock.IndexBufferDataBlockIndex[2] + mdlBlock.IndexBufferDataBlockNum[2]
            // i don't want to move this to that method right now, because i know sometimes the index is 0
            // but it seems to work fine in explorer...
            int totalBlocks = mdlBlock.StackBlockNum;
            totalBlocks += mdlBlock.RuntimeBlockNum;
            for( int i = 0; i < 3; i++ )
                totalBlocks += mdlBlock.VertexBufferBlockNum[ i ];
            for( int i = 0; i < 3; i++ )
                totalBlocks += mdlBlock.EdgeGeometryVertexBufferBlockNum[ i ];
            for( int i = 0; i < 3; i++ )
                totalBlocks += mdlBlock.IndexBufferBlockNum[ i ];

            var compressedBlockSizes = Reader.ReadStructures< UInt16 >( totalBlocks );
            int currentBlock = 0;
            int stackSize;
            int runtimeSize;
            int[] vertexDataOffsets = new int[3];
            int[] indexDataOffsets = new int[3];
            int[] vertexBufferSizes = new int[3];
            int[] indexBufferSizes = new int[3];

            ms.Seek( 0x44, SeekOrigin.Begin );

            Reader.Seek( baseOffset + mdlBlock.StackOffset );
            long stackStart = ms.Position;
            for( int i = 0; i < mdlBlock.StackBlockNum; i++ )
            {
                long lastPos = Reader.BaseStream.Position;
                ReadFileBlock( ms, buffer );
                Reader.Seek( lastPos + compressedBlockSizes[ currentBlock ] );
                currentBlock++;
            }

            long stackEnd = ms.Position;
            stackSize = (int)( stackEnd - stackStart );

            Reader.Seek( baseOffset + mdlBlock.RuntimeOffset );
            long runtimeStart = ms.Position;
            for( int i = 0; i < mdlBlock.RuntimeBlockNum; i++ )
            {
                long lastPos = Reader.BaseStream.Position;
                ReadFileBlock( ms, buffer );
                Reader.Seek( lastPos + compressedBlockSizes[ currentBlock ] );
                currentBlock++;
            }

            long runtimeEnd = ms.Position;
            runtimeSize = (int)( runtimeEnd - runtimeStart );

            for( int i = 0; i < 3; i++ )
            {
                if( mdlBlock.VertexBufferBlockNum[ i ] != 0 )
                {
                    int currentVertexOffset = (int)ms.Position;
                    if( i == 0 || currentVertexOffset != vertexDataOffsets[ i - 1 ] )
                        vertexDataOffsets[ i ] = currentVertexOffset;
                    else
                        vertexDataOffsets[ i ] = 0;

                    Reader.Seek( baseOffset + mdlBlock.VertexBufferOffset[ i ] );

                    for( int j = 0; j < mdlBlock.VertexBufferBlockNum[ i ]; j++ )
                    {
                        long lastPos = Reader.BaseStream.Position;
                        vertexBufferSizes[ i ] += (int)ReadFileBlock( ms, buffer );
                        Reader.Seek( lastPos + compressedBlockSizes[ currentBlock ] );
                        currentBlock++;
                    }
                }

                if( mdlBlock.EdgeGeometryVertexBufferBlockNum[ i ] != 0 )
                {
                    for( int j = 0; j < mdlBlock.EdgeGeometryVertexBufferBlockNum[ i ]; j++ )
                    {
                        long lastPos = Reader.BaseStream.Position;
                        ReadFileBlock( ms, buffer );
                        Reader.Seek( lastPos + compressedBlockSizes[ currentBlock ] );
                        currentBlock++;
                    }
                }

                if( mdlBlock.IndexBufferBlockNum[ i ] != 0 )
                {
                    int currentIndexOffset = (int)ms.Position;
                    if( i == 0 || currentIndexOffset != indexDataOffsets[ i - 1 ] )
                        indexDataOffsets[ i ] = currentIndexOffset;
                    else
                        indexDataOffsets[ i ] = 0;

                    // i guess this is only needed in the vertex area, for i = 0
                    // Reader.Seek( baseOffset + mdlBlock.IndexBufferOffset[ i ] );

                    for( int j = 0; j < mdlBlock.IndexBufferBlockNum[ i ]; j++ )
                    {
                        long lastPos = Reader.BaseStream.Position;
                        indexBufferSizes[ i ] += (int)ReadFileBlock( ms, buffer );
                        Reader.Seek( lastPos + compressedBlockSizes[ currentBlock ] );
                        currentBlock++;
                    }
                }
            }

            ms.Seek( 0, SeekOrigin.Begin );
            ms.Write( BitConverter.GetBytes( mdlBlock.Version ) );
            ms.Write( BitConverter.GetBytes( stackSize ) );
            ms.Write( BitConverter.GetBytes( runtimeSize ) );
            ms.Write( BitConverter.GetBytes( mdlBlock.VertexDeclarationNum ) );
            ms.Write( BitConverter.GetBytes( mdlBlock.MaterialNum ) );
            for( int i = 0; i < 3; i++ )
                ms.Write( BitConverter.GetBytes( vertexDataOffsets[ i ] ) );
            for( int i = 0; i < 3; i++ )
                ms.Write( BitConverter.GetBytes( indexDataOffsets[ i ] ) );
            for( int i = 0; i < 3; i++ )
                ms.Write( BitConverter.GetBytes( vertexBufferSizes[ i ] ) );
            for( int i = 0; i < 3; i++ )
                ms.Write( BitConverter.GetBytes( indexBufferSizes[ i ] ) );
            ms.Write( new[] { mdlBlock.NumLods } );
            ms.Write( BitConverter.GetBytes( mdlBlock.IndexBufferStreamingEnabled ) );
            ms.Write( BitConverter.GetBytes( mdlBlock.EdgeGeometryEnabled ) );
            ms.Write( new byte[] { 0 } );
        }

        private void ReadTextureFile( FileResource resource, byte[] buffer, MemoryStream ms )
        {
            var blocks = Reader.ReadStructures< LodBlock >( (int)resource.FileInfo.BlockCount );

            // if there is a mipmap header, the comp_offset
            // will not be 0
            uint mipMapSize = blocks[ 0 ].CompressedOffset;
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
                long runningBlockTotal = blocks[ i ].CompressedOffset + resource.FileInfo.Offset + resource.FileInfo.HeaderSize;
                ReadFileBlock( runningBlockTotal, ms, buffer, true );

                for( int j = 1; j < blocks[ i ].BlockCount; j++ )
                {
                    runningBlockTotal += (UInt32)Reader.ReadInt16();
                    ReadFileBlock( runningBlockTotal, ms, buffer, true );
                }

                // unknown
                Reader.ReadInt16();
            }
        }

        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        protected uint ReadFileBlock( MemoryStream dest, byte[] buffer, bool resetPosition = false )
        {
            return ReadFileBlock( Reader.BaseStream.Position, dest, buffer, resetPosition );
        }

        protected uint ReadFileBlock( long offset, MemoryStream dest, byte[] buffer, bool resetPosition = false )
        {
            var originalPosition = BaseStream.Position;
            BaseStream.Position = offset;

            var blockHeader = Reader.ReadStructure< DatBlockHeader >();

            // uncompressed block
            if( blockHeader.CompressedSize == 32000 )
            {
                // fucking .net holy hell
                var count = Reader.Read( buffer, (int)dest.Position, (int)blockHeader.UncompressedSize );

#if DEBUG
                if( count != (int)blockHeader.UncompressedSize )
                {
                    throw new Exception( "written bytes != uncompressed size :(" );
                }
#endif

                return blockHeader.UncompressedSize;
            }

            {
                using var zlibStream = new DeflateStream( BaseStream, CompressionMode.Decompress, true );

                // todo: check that this actually copies everything we need i guess
                var count = zlibStream.Read( buffer, (int)dest.Position, (int)blockHeader.UncompressedSize );
                dest.Position += (int)blockHeader.UncompressedSize;
            }

            if( resetPosition )
            {
                BaseStream.Position = originalPosition;
            }

            return blockHeader.UncompressedSize;
        }

        public void Dispose()
        {
            Reader?.Dispose();
        }
    }
}