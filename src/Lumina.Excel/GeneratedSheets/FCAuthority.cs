// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "FCAuthority", columnHash: 0x1ee79c01 )]
    public class FCAuthority : ExcelRow
    {
        
        public SeString Name;
        public LazyRow< FCAuthorityCategory > FCAuthorityCategory;
        public byte Unknown2;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Name = parser.ReadColumn< SeString >( 0 );
            FCAuthorityCategory = new LazyRow< FCAuthorityCategory >( lumina, parser.ReadColumn< int >( 1 ), language );
            Unknown2 = parser.ReadColumn< byte >( 2 );
        }
    }
}