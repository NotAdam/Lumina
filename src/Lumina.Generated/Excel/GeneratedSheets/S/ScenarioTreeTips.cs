using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ScenarioTreeTips", columnHash: 0x71371b8c )]
    public class ScenarioTreeTips : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 01 offset: 0000
        public uint Tips1;

        // col: 03 offset: 0004
        public uint Tips2;

        // col: 02 offset: 0008
        public ushort unknown8;

        // col: 00 offset: 000a
        public byte unknowna;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 1 offset: 0000
            Tips1 = parser.ReadOffset< uint >( 0x0 );

            // col: 3 offset: 0004
            Tips2 = parser.ReadOffset< uint >( 0x4 );

            // col: 2 offset: 0008
            unknown8 = parser.ReadOffset< ushort >( 0x8 );

            // col: 0 offset: 000a
            unknowna = parser.ReadOffset< byte >( 0xa );


        }
    }
}