using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "AnimaWeapon5TradeItem", columnHash: 0x40f1e693 )]
    public class AnimaWeapon5TradeItem : IExcelRow
    {
        public struct UnkStruct3Struct
        {
            public uint ItemName;
            public bool IsHQ;
            public byte Quantity;
        }
        
        public byte Unknown0;
        public LazyRow< Item > CrystalSand;
        public byte Qty;
        public UnkStruct3Struct[] UnkStruct3;
        public LazyRow< AnimaWeapon5PatternGroup > Category;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Unknown0 = parser.ReadColumn< byte >( 0 );
            CrystalSand = new LazyRow< Item >( lumina, parser.ReadColumn< uint >( 1 ) );
            Qty = parser.ReadColumn< byte >( 2 );
            UnkStruct3 = new UnkStruct3Struct[ 8 ];
            for( var i = 0; i < 8; i++ )
            {
                UnkStruct3[ i ] = new UnkStruct3Struct();
                UnkStruct3[ i ].ItemName = parser.ReadColumn< uint >( 3 + ( i * 3 + 0 ) );
                UnkStruct3[ i ].IsHQ = parser.ReadColumn< bool >( 3 + ( i * 3 + 1 ) );
                UnkStruct3[ i ].Quantity = parser.ReadColumn< byte >( 3 + ( i * 3 + 2 ) );
            }
            Category = new LazyRow< AnimaWeapon5PatternGroup >( lumina, parser.ReadColumn< byte >( 27 ) );
        }
    }
}