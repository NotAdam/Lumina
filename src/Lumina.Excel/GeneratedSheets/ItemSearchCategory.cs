// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ItemSearchCategory", columnHash: 0x95df38b2 )]
    public partial class ItemSearchCategory : ExcelRow
    {
        
        public SeString Name { get; set; }
        public int Icon { get; set; }
        public byte Category { get; set; }
        public byte Order { get; set; }
        public LazyRow< ClassJob > ClassJob { get; set; }
        public bool Unknown5 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Name = parser.ReadColumn< SeString >( 0 );
            Icon = parser.ReadColumn< int >( 1 );
            Category = parser.ReadColumn< byte >( 2 );
            Order = parser.ReadColumn< byte >( 3 );
            ClassJob = new LazyRow< ClassJob >( gameData, parser.ReadColumn< sbyte >( 4 ), language );
            Unknown5 = parser.ReadColumn< bool >( 5 );
        }
    }
}