using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DailySupplyItem", columnHash: 0x5e7b2507 )]
    public class DailySupplyItem : IExcelRow
    {
        public struct UnkStruct0Struct
        {
            public int Item;
            public byte Quantity;
            public byte RecipeLevel;
        }
        
        public UnkStruct0Struct[] UnkStruct0;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            for( var i = 0; i < 8; i++ )
            {
                UnkStruct0[ i ] = new UnkStruct0Struct();
                UnkStruct0[ i ].Item = parser.ReadColumn< int >( 0 + ( i * 8 + 0 ) );
                UnkStruct0[ i ].Quantity = parser.ReadColumn< byte >( 0 + ( i * 8 + 1 ) );
                UnkStruct0[ i ].RecipeLevel = parser.ReadColumn< byte >( 0 + ( i * 8 + 2 ) );
            }
        }
    }
}