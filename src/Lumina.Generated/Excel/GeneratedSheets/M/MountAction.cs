using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MountAction", columnHash: 0x58822da3 )]
    public class MountAction : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public ushort[] Action;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Action = new ushort[6];
            Action[0] = parser.ReadOffset< ushort >( 0x0 );
            Action[1] = parser.ReadOffset< ushort >( 0x2 );
            Action[2] = parser.ReadOffset< ushort >( 0x4 );
            Action[3] = parser.ReadOffset< ushort >( 0x6 );
            Action[4] = parser.ReadOffset< ushort >( 0x8 );
            Action[5] = parser.ReadOffset< ushort >( 0xa );


        }
    }
}