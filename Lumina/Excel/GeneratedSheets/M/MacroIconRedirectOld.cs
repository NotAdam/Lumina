using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MacroIconRedirectOld", columnHash: 0x5c9aa6b3 )]
    public class MacroIconRedirectOld : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public uint IconOld;

        // col: 01 offset: 0004
        public int IconNew;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            IconOld = parser.ReadOffset< uint >( 0x0 );

            // col: 1 offset: 0004
            IconNew = parser.ReadOffset< int >( 0x4 );


        }
    }
}