using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ScenarioTreeTipsClassQuest", columnHash: 0xae1d30a7 )]
    public class ScenarioTreeTipsClassQuest : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public uint Quest;

        // col: 03 offset: 0004
        public uint RequiredQuest;

        // col: 01 offset: 0008
        public ushort RequiredLevel;

        // col: 02 offset: 000a
        public byte RequiredExpansion;

        // col: 04 offset: 000b
        public bool packedb_1;
        public byte packedb;
        public bool packedb_2;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Quest = parser.ReadOffset< uint >( 0x0 );

            // col: 3 offset: 0004
            RequiredQuest = parser.ReadOffset< uint >( 0x4 );

            // col: 1 offset: 0008
            RequiredLevel = parser.ReadOffset< ushort >( 0x8 );

            // col: 2 offset: 000a
            RequiredExpansion = parser.ReadOffset< byte >( 0xa );

            // col: 4 offset: 000b
            packedb = parser.ReadOffset< byte >( 0xb, ExcelColumnDataType.UInt8 );

            packedb_1 = ( packedb & 0x1 ) == 0x1;
            packedb_2 = ( packedb & 0x2 ) == 0x2;


        }
    }
}