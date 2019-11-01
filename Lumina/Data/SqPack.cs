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
            get => BitConverter.IsLittleEndian && SqPackHeader.platformId == PlatformId.PS3;
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

            //fs.Position = SqPackHeader.size;
        }

        public T ReadFile< T >( uint offset ) where T : FileResource
        {
            using var fs = File.OpenRead();
            using var br = new BinaryReader( fs );

            fs.Position = offset;

            var fileInfo = br.ReadStructure< SqPackFileInfo >();

            var file = Activator.CreateInstance< T >();
            file.FileInfo = fileInfo;
            file.BaseOffset = offset;

            switch( fileInfo.Type )
            {
                case FileType.Empty:
                    throw new FileNotFoundException( $"The file located at 0x{offset:x} in dat {Name} is empty." );

                case FileType.Standard:
                    ReadStandardFile( file, fs, br );
                    break;

                case FileType.Model:
                    break;

                case FileType.Texture:
                    break;

                default:
                    throw new NotImplementedException( $"File Type {(UInt32) fileInfo.Type} is not implemented." );
            }

            file.LoadFile();

            return file;
        }

        protected void ReadStandardFile( FileResource resource, FileStream fs, BinaryReader br )
        {
            var blocks = new List< DatStdFileBlockInfos >();

            // todo: do this in a single read, multiple is a bit shit
            for( var i = 0; i < resource.FileInfo.number_of_blocks; i++ )
            {
                blocks.Add( br.ReadStructure< DatStdFileBlockInfos >() );
            }

            var ms = resource.DataSections[ 0 ] = new MemoryStream();

            foreach( var block in blocks )
            {
                ReadFileBlock( resource.BaseOffset + resource.FileInfo.Size + block.offset, fs, br, ms );
            }

            // reset position ready for reading
            ms.Position = 0;
        }

        protected void ReadFileBlock( uint offset, FileStream fs, BinaryReader br, MemoryStream dest )
        {
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
        }
    }
}