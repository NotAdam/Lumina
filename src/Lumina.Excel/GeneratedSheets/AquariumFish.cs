// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "AquariumFish", columnHash: 0x9b5e32ba )]
    public class AquariumFish : ExcelRow
    {
        
        public LazyRow< AquariumWater > AquariumWater;
        public byte Size;
        public LazyRow< Item > Item;
        public ushort Unknown3;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            AquariumWater = new LazyRow< AquariumWater >( lumina, parser.ReadColumn< byte >( 0 ), language );
            Size = parser.ReadColumn< byte >( 1 );
            Item = new LazyRow< Item >( lumina, parser.ReadColumn< uint >( 2 ), language );
            Unknown3 = parser.ReadColumn< ushort >( 3 );
        }
    }
}