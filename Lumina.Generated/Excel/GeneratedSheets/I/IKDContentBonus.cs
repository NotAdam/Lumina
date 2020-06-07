using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "IKDContentBonus", columnHash: 0xb7d9b7a3 )]
    public class IKDContentBonus : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public string Objective;

        // col: 01 offset: 0004
        public string Requirement;

        // col: 03 offset: 0008
        public uint Image;

        // col: 02 offset: 000c
        public ushort unknownc;

        // col: 04 offset: 000e
        public byte Order;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Objective = parser.ReadOffset< string >( 0x0 );

            // col: 1 offset: 0004
            Requirement = parser.ReadOffset< string >( 0x4 );

            // col: 3 offset: 0008
            Image = parser.ReadOffset< uint >( 0x8 );

            // col: 2 offset: 000c
            unknownc = parser.ReadOffset< ushort >( 0xc );

            // col: 4 offset: 000e
            Order = parser.ReadOffset< byte >( 0xe );


        }
    }
}