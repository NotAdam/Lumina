using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GatheringRarePopTimeTable", columnHash: 0x865de322 )]
    public class GatheringRarePopTimeTable : IExcelRow
    {
        public struct UnkStruct0Struct
        {
            public ushort StartTime;
            public ushort Durationm;
        }
        
        public UnkStruct0Struct[] UnkStruct0;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            UnkStruct0 = new UnkStruct0Struct[ 3 ];
            for( var i = 0; i < 3; i++ )
            {
                UnkStruct0[ i ] = new UnkStruct0Struct();
                UnkStruct0[ i ].StartTime = parser.ReadColumn< ushort >( 0 + ( i * 2 + 0 ) );
                UnkStruct0[ i ].Durationm = parser.ReadColumn< ushort >( 0 + ( i * 2 + 1 ) );
            }
        }
    }
}