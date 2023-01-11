// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "AquariumFish", columnHash: 0x9b5e32ba )]
    public partial class AquariumFish : ExcelRow
    {
        
        public LazyRow< AquariumWater > AquariumWater { get; set; }
        public byte Size { get; set; }
        public LazyRow< Item > Item { get; set; }
        public ushort Unknown3 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            AquariumWater = new LazyRow< AquariumWater >( gameData, parser.ReadColumn< byte >( 0 ), language );
            Size = parser.ReadColumn< byte >( 1 );
            Item = new LazyRow< Item >( gameData, parser.ReadColumn< uint >( 2 ), language );
            Unknown3 = parser.ReadColumn< ushort >( 3 );
        }
    }
}