using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "EventIconType", columnHash: 0x6ce9409c )]
    public class EventIconType : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT


        // col: 00 offset: 0000
        public uint NpcIconAvailable;

        // col: 01 offset: 0004
        public uint MapIconAvailable;

        // col: 02 offset: 0008
        public uint NpcIconInvalid;

        // col: 03 offset: 000c
        public uint MapIconInvalid;

        // col: 04 offset: 0010
        public byte IconRange;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            NpcIconAvailable = parser.ReadOffset< uint >( 0x0 );

            // col: 1 offset: 0004
            MapIconAvailable = parser.ReadOffset< uint >( 0x4 );

            // col: 2 offset: 0008
            NpcIconInvalid = parser.ReadOffset< uint >( 0x8 );

            // col: 3 offset: 000c
            MapIconInvalid = parser.ReadOffset< uint >( 0xc );

            // col: 4 offset: 0010
            IconRange = parser.ReadOffset< byte >( 0x10 );


        }
    }
}