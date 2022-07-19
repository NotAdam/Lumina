using System.IO;
using System.Runtime.CompilerServices;
using Lumina.Data.Attributes;
using Lumina.Data.Structs.Excel;
using Lumina.Extensions;
using Lumina.Misc;

namespace Lumina.Data.Files.Excel
{
    [FileExtension( ".exh" )]
    public class ExcelHeaderFile : FileResource
    {
        public ExcelHeaderFile()
        {
        }

        public const string Magic = "EXHF";

        public ExcelHeaderHeader Header { get; private set; }

        public ExcelColumnDefinition[] ColumnDefinitions { get; private set; }

        public ExcelDataPagination[] DataPages { get; private set; }

        public Language[] Languages { get; private set; }

        public override unsafe void LoadFile()
        {
            // exd data is always in big endian
            Reader.IsLittleEndian = false;

            Header = ExcelHeaderHeader.Read( Reader );

            if(
                Header.Magic[ 0 ] != 'E' ||
                Header.Magic[ 1 ] != 'X' ||
                Header.Magic[ 2 ] != 'H' ||
                Header.Magic[ 3 ] != 'F' )
            {
                throw new InvalidDataException( "fucked exh file :(((((" );
            }

            ColumnDefinitions = Reader.ReadStructuresAsArray< ExcelColumnDefinition >( Header.ColumnCount );
            DataPages = Reader.ReadStructuresAsArray< ExcelDataPagination >( Header.PageCount );

            Languages = new Language[ Header.LanguageCount ];

            for( var i = 0; i < Header.LanguageCount; i++ )
            {
                Languages[ i ] = (Language)Reader.ReadByte();

                // optional parameter string (unused?)
                Reader.ReadStringData();
            }
        }

        public uint GetColumnsHash()
        {
            var headerSize = Unsafe.SizeOf< ExcelHeaderHeader >();
            var span = DataSpan.Slice( headerSize, Unsafe.SizeOf< ExcelColumnDefinition >() * Header.ColumnCount );

            return Crc32.Get( span );
        }

        public string GetColumnsHashString()
        {
            return GetColumnsHash().ToString( "x8" );
        }
    }
}