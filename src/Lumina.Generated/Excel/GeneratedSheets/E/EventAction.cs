using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "EventAction", columnHash: 0x1c60d673 )]
    public class EventAction : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public string Name;

        // col: 01 offset: 0004
        public ushort Icon;

        // col: 03 offset: 0006
        public ushort[] Animation;

        // col: 02 offset: 000c
        public byte CastTime;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Name = parser.ReadOffset< string >( 0x0 );

            // col: 1 offset: 0004
            Icon = parser.ReadOffset< ushort >( 0x4 );

            // col: 3 offset: 0006
            Animation = new ushort[3];
            Animation[0] = parser.ReadOffset< ushort >( 0x6 );
            Animation[1] = parser.ReadOffset< ushort >( 0x8 );
            Animation[2] = parser.ReadOffset< ushort >( 0xa );

            // col: 2 offset: 000c
            CastTime = parser.ReadOffset< byte >( 0xc );


        }
    }
}