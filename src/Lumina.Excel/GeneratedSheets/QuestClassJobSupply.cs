// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "QuestClassJobSupply", columnHash: 0xdd620f3e )]
    public partial class QuestClassJobSupply : ExcelRow
    {
        
        public LazyRow< ClassJobCategory > ClassJobCategory { get; set; }
        public byte Unknown1 { get; set; }
        public LazyRow< ENpcResident > ENpcResident { get; set; }
        public LazyRow< Item > Item { get; set; }
        public byte AmountRequired { get; set; }
        public bool ItemHQ { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            ClassJobCategory = new LazyRow< ClassJobCategory >( gameData, parser.ReadColumn< byte >( 0 ), language );
            Unknown1 = parser.ReadColumn< byte >( 1 );
            ENpcResident = new LazyRow< ENpcResident >( gameData, parser.ReadColumn< uint >( 2 ), language );
            Item = new LazyRow< Item >( gameData, parser.ReadColumn< uint >( 3 ), language );
            AmountRequired = parser.ReadColumn< byte >( 4 );
            ItemHQ = parser.ReadColumn< bool >( 5 );
        }
    }
}