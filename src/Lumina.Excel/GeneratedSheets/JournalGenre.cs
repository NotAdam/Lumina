// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "JournalGenre", columnHash: 0x2c6b75bb )]
    public partial class JournalGenre : ExcelRow
    {
        
        public int Icon { get; set; }
        public LazyRow< JournalCategory > JournalCategory { get; set; }
        public bool Unknown2 { get; set; }
        public SeString Name { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Icon = parser.ReadColumn< int >( 0 );
            JournalCategory = new LazyRow< JournalCategory >( gameData, parser.ReadColumn< byte >( 1 ), language );
            Unknown2 = parser.ReadColumn< bool >( 2 );
            Name = parser.ReadColumn< SeString >( 3 );
        }
    }
}