using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "FCActivity", columnHash: 0xe45dc889 )]
    public class FCActivity : IExcelRow
    {
        // column defs from Wed, 15 Jan 2020 17:17:16 GMT


        // col: 00 offset: 0000
        public string Text;

        // col: 01 offset: 0004
        public byte SelfKind;

        // col: 02 offset: 0005
        public byte TargetKind;

        // col: 03 offset: 0006
        public byte NumParam;

        // col: 04 offset: 0007
        public byte FCActivityCategory;

        // col: 05 offset: 0008
        public sbyte IconType;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Text = parser.ReadOffset< string >( 0x0 );

            // col: 1 offset: 0004
            SelfKind = parser.ReadOffset< byte >( 0x4 );

            // col: 2 offset: 0005
            TargetKind = parser.ReadOffset< byte >( 0x5 );

            // col: 3 offset: 0006
            NumParam = parser.ReadOffset< byte >( 0x6 );

            // col: 4 offset: 0007
            FCActivityCategory = parser.ReadOffset< byte >( 0x7 );

            // col: 5 offset: 0008
            IconType = parser.ReadOffset< sbyte >( 0x8 );


        }
    }
}