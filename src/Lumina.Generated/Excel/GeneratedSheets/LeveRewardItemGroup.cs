using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "LeveRewardItemGroup", columnHash: 0xf065e622 )]
    public class LeveRewardItemGroup : IExcelRow
    {
        public struct UnkStruct0Struct
        {
            public int Item;
            public byte Count;
            public bool HQ;
        }
        
        public UnkStruct0Struct[] UnkStruct0;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            UnkStruct0 = new UnkStruct0Struct[ 9 ];
            for( var i = 0; i < 9; i++ )
            {
                UnkStruct0[ i ] = new UnkStruct0Struct();
                UnkStruct0[ i ].Item = parser.ReadColumn< int >( 0 + ( i * 3 + 0 ) );
                UnkStruct0[ i ].Count = parser.ReadColumn< byte >( 0 + ( i * 3 + 1 ) );
                UnkStruct0[ i ].HQ = parser.ReadColumn< bool >( 0 + ( i * 3 + 2 ) );
            }
        }
    }
}