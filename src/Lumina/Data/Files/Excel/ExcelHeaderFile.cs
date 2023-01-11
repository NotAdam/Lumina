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

            ColumnDefinitions = new ExcelColumnDefinition[Header.ColumnCount];
            DataPages = new ExcelDataPagination[Header.PageCount];
            for( int i = 0; i < Header.ColumnCount; i++ ) ColumnDefinitions[ i ] = ExcelColumnDefinition.Read( Reader );
            for( int i = 0; i < Header.PageCount; i++ ) DataPages[ i ] = ExcelDataPagination.Read( Reader );

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
            // 32 is size of header, can't unsafe because of non-fixed arrays
            var span = DataSpan.Slice( 32, Unsafe.SizeOf< ExcelColumnDefinition >() * Header.ColumnCount );

            return Crc32.Get( span );
        }

        public string GetColumnsHashString()
        {
            return GetColumnsHash().ToString( "x8" );
        }
    }
}