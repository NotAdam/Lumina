using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GuardianDeity", columnHash: 0x79bad589 )]
    public class GuardianDeity : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public string Name;

        // col: 01 offset: 0004
        public string Description;

        // col: 02 offset: 0008
        public ushort Icon;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Name = parser.ReadOffset< string >( 0x0 );

            // col: 1 offset: 0004
            Description = parser.ReadOffset< string >( 0x4 );

            // col: 2 offset: 0008
            Icon = parser.ReadOffset< ushort >( 0x8 );


        }
    }
}