// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "AnimaWeapon5TradeItem", columnHash: 0x40f1e693 )]
    public partial class AnimaWeapon5TradeItem : ExcelRow
    {
        public class AnimaWeapon5TradeItemUnkData3Obj
        {
            public uint ItemName { get; set; }
            public bool IsHQ { get; set; }
            public byte Quantity { get; set; }
        }
        
        public byte Unknown0 { get; set; }
        public LazyRow< Item > CrystalSand { get; set; }
        public byte Qty { get; set; }
        public AnimaWeapon5TradeItemUnkData3Obj[] UnkData3 { get; set; }
        public LazyRow< AnimaWeapon5PatternGroup > Category { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< byte >( 0 );
            CrystalSand = new LazyRow< Item >( gameData, parser.ReadColumn< uint >( 1 ), language );
            Qty = parser.ReadColumn< byte >( 2 );
            UnkData3 = new AnimaWeapon5TradeItemUnkData3Obj[ 8 ];
            for( var i = 0; i < 8; i++ )
            {
                UnkData3[ i ] = new AnimaWeapon5TradeItemUnkData3Obj();
                UnkData3[ i ].ItemName = parser.ReadColumn< uint >( 3 + ( i * 3 + 0 ) );
                UnkData3[ i ].IsHQ = parser.ReadColumn< bool >( 3 + ( i * 3 + 1 ) );
                UnkData3[ i ].Quantity = parser.ReadColumn< byte >( 3 + ( i * 3 + 2 ) );
            }
            Category = new LazyRow< AnimaWeapon5PatternGroup >( gameData, parser.ReadColumn< byte >( 27 ), language );
        }
    }
}