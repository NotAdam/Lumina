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

        public T ReadFile< T >( uint offset ) where T : FileResource
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
                    ReadModelFile( file, fs, br, ms );
                    break;

                case FileType.Texture:
                    ReadTextureFile( file, fs, br, ms );
                    break;

                default:
                    throw new NotImplementedException( $"File Type {(UInt32) fileInfo.Type} is not implemented." );
            }

            file.Data = ms.ToArray();
            file.LoadFile();

            return file;
        }

        private void ReadStandardFile( FileResource resource, FileStream fs, BinaryReader br, MemoryStream ms )
        {
            var blocks = br.ReadStructures< DatStdFileBlockInfos >( (int) resource.FileInfo.BlockCount );

            foreach( var block in blocks )
            {
                ReadFileBlock( resource.FileInfo.Offset + resource.FileInfo.HeaderSize + block.offset, fs, br, ms );
            }

            // reset position ready for reading
            ms.Position = 0;
        }

        private void ReadModelFile( FileResource resource, FileStream fs, BinaryReader br, MemoryStream ms )
        {
            var blockInfo = br.ReadStructure< DatMdlFileBlockInfo >();
            
            
        }

        private void ReadTextureFile( FileResource resource, FileStream fs, BinaryReader br, MemoryStream ms )
        {
            var blocks = br.ReadStructures< LodBlock >( (int) resource.FileInfo.BlockCount );

            // if there is a mipmap header, the comp_offset
            // will not be 0
            uint mipMapSize = blocks[ 0 ].comp_offset;
            if( mipMapSize != 0 )
            {
                long originalPos = fs.Position;

                fs.Position = resource.FileInfo.Offset + resource.FileInfo.HeaderSize;
                ms.Write( br.ReadBytes( (int) mipMapSize ) );

                fs.Position = originalPos;
            }

            // i is for texture blocks, j is 'data blocks'...
            for( byte i = 0; i < blocks.Count; i++ )
            {
                // start from comp_offset
                UInt32 runningBlockTotal = blocks[ i ].comp_offset + resource.FileInfo.Offset + resource.FileInfo.HeaderSize;
                ReadFileBlock( runningBlockTotal, fs, br, ms );

                for( int j = 1; j < blocks[ i ].block_count; j++ )
                {
                    runningBlockTotal += (UInt32) br.ReadInt16();
                    ReadFileBlock( runningBlockTotal, fs, br, ms );
                }

                // unknown
                br.ReadInt16();
            }
        }

        protected void ReadFileBlock( uint offset, FileStream fs, BinaryReader br, MemoryStream dest )
        {
            long originalPosition = fs.Position;
            fs.Position = offset;

            var blockHeader = br.ReadStructure< DatBlockHeader >();

            // uncompressed block
            if( blockHeader.compressed_size == 32000 )
            {
                dest.Write( br.ReadBytes( (int) blockHeader.uncompressed_size ) );

                return;
            }

            var data = br.ReadBytes( (int) blockHeader.uncompressed_size );

            var inflater = new Inflater( true );

            inflater.SetInput( data );
            var bytesInflated = inflater.Inflate( data );

            if( bytesInflated == blockHeader.uncompressed_size )
            {
                dest.Write( data );
            }
            else
            {
                throw new SqPackInflateException(
                    "Failed to inflate block, bytesInflated != blockHeader.uncompressed_size" );
            }

            fs.Position = originalPosition;
        }
    }
}