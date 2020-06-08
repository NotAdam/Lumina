using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "FccShop", columnHash: 0x21a0d047 )]
    public class FccShop : IExcelRow
    {
        public struct UnkStruct1Struct
        {
            public uint Item;
        }
        public struct UnkStruct11Struct
        {
            public uint Cost;
        }
        public struct UnkStruct21Struct
        {
            public byte FCRankRequired;
        }
        
        public string Name;
        public UnkStruct1Struct[] UnkStruct1;
        public UnkStruct11Struct[] UnkStruct11;
        public UnkStruct21Struct[] UnkStruct21;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Name = parser.ReadColumn< string >( 0 );
            UnkStruct1 = new UnkStruct1Struct[ 10 ];
            for( var i = 0; i < 10; i++ )
            {
                UnkStruct1[ i ] = new UnkStruct1Struct();
                UnkStruct1[ i ].Item = parser.ReadColumn< uint >( 1 + ( i * 1 + 0 ) );
            }
            UnkStruct11 = new UnkStruct11Struct[ 10 ];
            for( var i = 0; i < 10; i++ )
            {
                UnkStruct11[ i ] = new UnkStruct11Struct();
                UnkStruct11[ i ].Cost = parser.ReadColumn< uint >( 11 + ( i * 1 + 0 ) );
            }
            UnkStruct21 = new UnkStruct21Struct[ 10 ];
            for( var i = 0; i < 10; i++ )
            {
                UnkStruct21[ i ] = new UnkStruct21Struct();
                UnkStruct21[ i ].FCRankRequired = parser.ReadColumn< byte >( 21 + ( i * 1 + 0 ) );
            }
        }
    }
}