using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MountTransient", columnHash: 0x7f711762 )]
    public class MountTransient : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public string Description;

        // col: 01 offset: 0004
        public string DescriptionEnhanced;

        // col: 02 offset: 0008
        public string Tooltip;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Description = parser.ReadOffset< string >( 0x0 );

            // col: 1 offset: 0004
            DescriptionEnhanced = parser.ReadOffset< string >( 0x4 );

            // col: 2 offset: 0008
            Tooltip = parser.ReadOffset< string >( 0x8 );


        }
    }
}