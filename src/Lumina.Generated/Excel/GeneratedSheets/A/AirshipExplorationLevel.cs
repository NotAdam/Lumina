using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "AirshipExplorationLevel", columnHash: 0x382abf74 )]
    public class AirshipExplorationLevel : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 01 offset: 0000
        public uint ExpToNext;

        // col: 00 offset: 0004
        public ushort unknown4;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 1 offset: 0000
            ExpToNext = parser.ReadOffset< uint >( 0x0 );

            // col: 0 offset: 0004
            unknown4 = parser.ReadOffset< ushort >( 0x4 );


        }
    }
}