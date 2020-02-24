using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DawnMemberUIParam", columnHash: 0x0fd503c6 )]
    public class DawnMemberUIParam : IExcelRow
    {
        // column defs from Mon, 15 Jul 2019 14:22:54 GMT


        // col: 02 offset: 0000
        public string ClassPlural;

        // col: 01 offset: 0004
        public uint VoiceLine;

        // col: 00 offset: 0008
        public string ClassSingular;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 2 offset: 0000
            ClassPlural = parser.ReadOffset< string >( 0x0 );

            // col: 1 offset: 0004
            VoiceLine = parser.ReadOffset< uint >( 0x4 );

            // col: 0 offset: 0008
            ClassSingular = parser.ReadOffset< string >( 0x8 );


        }
    }
}