using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "NotoriousMonster", columnHash: 0x307c9206 )]
    public class NotoriousMonster : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 02 offset: 0000
        public uint BNpcName;

        // col: 00 offset: 0004
        public int BNpcBase;

        // col: 03 offset: 0008
        public ushort unknown8;

        // col: 01 offset: 000a
        public byte Rank;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 2 offset: 0000
            BNpcName = parser.ReadOffset< uint >( 0x0 );

            // col: 0 offset: 0004
            BNpcBase = parser.ReadOffset< int >( 0x4 );

            // col: 3 offset: 0008
            unknown8 = parser.ReadOffset< ushort >( 0x8 );

            // col: 1 offset: 000a
            Rank = parser.ReadOffset< byte >( 0xa );


        }
    }
}