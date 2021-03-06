// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "QuestClassJobSupply", columnHash: 0xdd620f3e )]
    public class QuestClassJobSupply : ExcelRow
    {
        
        public LazyRow< ClassJobCategory > ClassJobCategory { get; set; }
        public byte Unknown1 { get; set; }
        public LazyRow< ENpcResident > ENpcResident { get; set; }
        public LazyRow< Item > Item { get; set; }
        public byte Unknown4 { get; set; }
        public bool Unknown5 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            ClassJobCategory = new LazyRow< ClassJobCategory >( gameData, parser.ReadColumn< byte >( 0 ), language );
            Unknown1 = parser.ReadColumn< byte >( 1 );
            ENpcResident = new LazyRow< ENpcResident >( gameData, parser.ReadColumn< uint >( 2 ), language );
            Item = new LazyRow< Item >( gameData, parser.ReadColumn< uint >( 3 ), language );
            Unknown4 = parser.ReadColumn< byte >( 4 );
            Unknown5 = parser.ReadColumn< bool >( 5 );
        }
    }
}