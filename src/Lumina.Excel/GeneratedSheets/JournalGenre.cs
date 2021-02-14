// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "JournalGenre", columnHash: 0x2c6b75bb )]
    public class JournalGenre : ExcelRow
    {
        
        public int Icon;
        public LazyRow< JournalCategory > JournalCategory;
        public bool Unknown2;
        public SeString Name;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Icon = parser.ReadColumn< int >( 0 );
            JournalCategory = new LazyRow< JournalCategory >( lumina, parser.ReadColumn< byte >( 1 ), language );
            Unknown2 = parser.ReadColumn< bool >( 2 );
            Name = parser.ReadColumn< SeString >( 3 );
        }
    }
}