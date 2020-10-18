// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CompanyCraftProcess", columnHash: 0x090b916f )]
    public class CompanyCraftProcess : IExcelRow
    {
        public struct UnkStruct0Struct
        {
            public ushort SupplyItem;
            public ushort SetQuantity;
            public ushort SetsRequired;
        }
        
        public UnkStruct0Struct[] UnkStruct0;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            UnkStruct0 = new UnkStruct0Struct[ 12 ];
            for( var i = 0; i < 12; i++ )
            {
                UnkStruct0[ i ] = new UnkStruct0Struct();
                UnkStruct0[ i ].SupplyItem = parser.ReadColumn< ushort >( 0 + ( i * 3 + 0 ) );
                UnkStruct0[ i ].SetQuantity = parser.ReadColumn< ushort >( 0 + ( i * 3 + 1 ) );
                UnkStruct0[ i ].SetsRequired = parser.ReadColumn< ushort >( 0 + ( i * 3 + 2 ) );
            }
        }
    }
}