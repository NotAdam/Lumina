using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ActionCastTimeline", columnHash: 0x2020acf6 )]
    public class ActionCastTimeline : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public ushort Name;

        // col: 01 offset: 0002
        public ushort VFX;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Name = parser.ReadOffset< ushort >( 0x0 );

            // col: 1 offset: 0002
            VFX = parser.ReadOffset< ushort >( 0x2 );


        }
    }
}