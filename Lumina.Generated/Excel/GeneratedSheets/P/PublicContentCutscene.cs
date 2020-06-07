using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "PublicContentCutscene", columnHash: 0x5d58cc84 )]
    public class PublicContentCutscene : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public uint Cutscene;

        // col: 01 offset: 0004
        public uint Cutscene2;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Cutscene = parser.ReadOffset< uint >( 0x0 );

            // col: 1 offset: 0004
            Cutscene2 = parser.ReadOffset< uint >( 0x4 );


        }
    }
}