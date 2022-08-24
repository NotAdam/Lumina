// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "BuddyItem", columnHash: 0xfa9fc03d )]
    public partial class BuddyItem : ExcelRow
    {
        
        public LazyRow< Item > Item { get; set; }
        public bool UseField { get; set; }
        public bool UseTraining { get; set; }
        public bool Unknown3 { get; set; }
        public byte Status { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Item = new LazyRow< Item >( gameData, parser.ReadColumn< ushort >( 0 ), language );
            UseField = parser.ReadColumn< bool >( 1 );
            UseTraining = parser.ReadColumn< bool >( 2 );
            Unknown3 = parser.ReadColumn< bool >( 3 );
            Status = parser.ReadColumn< byte >( 4 );
        }
    }
}