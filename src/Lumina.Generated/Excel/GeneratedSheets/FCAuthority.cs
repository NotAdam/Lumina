// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "FCAuthority", columnHash: 0x1ee79c01 )]
    public class FCAuthority : IExcelRow
    {
        
        public string Name;
        public LazyRow< FCAuthorityCategory > FCAuthorityCategory;
        public byte Unknown2;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Name = parser.ReadColumn< string >( 0 );
            FCAuthorityCategory = new LazyRow< FCAuthorityCategory >( lumina, parser.ReadColumn< int >( 1 ), language );
            Unknown2 = parser.ReadColumn< byte >( 2 );
        }
    }
}