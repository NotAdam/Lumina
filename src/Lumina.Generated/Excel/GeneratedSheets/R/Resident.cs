using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Resident", columnHash: 0x94f55c73 )]
    public class Resident : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 01 offset: 0000
        public ulong Model;

        // col: 02 offset: 0008
        public int NpcYell;

        // col: 00 offset: 000c
        public byte unknownc;

        // col: 03 offset: 000d
        public byte ResidentMotionType;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 1 offset: 0000
            Model = parser.ReadOffset< ulong >( 0x0 );

            // col: 2 offset: 0008
            NpcYell = parser.ReadOffset< int >( 0x8 );

            // col: 0 offset: 000c
            unknownc = parser.ReadOffset< byte >( 0xc );

            // col: 3 offset: 000d
            ResidentMotionType = parser.ReadOffset< byte >( 0xd );


        }
    }
}