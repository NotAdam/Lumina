using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HWDInfoBoardArticleTransient", columnHash: 0x11a44a12 )]
    public class HWDInfoBoardArticleTransient : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 01 offset: 0000
        public string Text;

        // col: 02 offset: 0004
        public string NpcName;

        // col: 00 offset: 0008
        public uint Image;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 1 offset: 0000
            Text = parser.ReadOffset< string >( 0x0 );

            // col: 2 offset: 0004
            NpcName = parser.ReadOffset< string >( 0x4 );

            // col: 0 offset: 0008
            Image = parser.ReadOffset< uint >( 0x8 );


        }
    }
}