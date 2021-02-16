// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "QuestClassJobSupply", columnHash: 0xdd620f3e )]
    public class QuestClassJobSupply : ExcelRow
    {
        
        public LazyRow< ClassJobCategory > ClassJobCategory;
        public byte Unknown1;
        public LazyRow< ENpcResident > ENpcResident;
        public LazyRow< Item > Item;
        public byte Unknown4;
        public bool Unknown5;
        

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