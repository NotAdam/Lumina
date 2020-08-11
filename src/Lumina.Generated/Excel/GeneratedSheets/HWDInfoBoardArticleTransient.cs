// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HWDInfoBoardArticleTransient", columnHash: 0x11a44a12 )]
    public class HWDInfoBoardArticleTransient : IExcelRow
    {
        
        public uint Image;
        public string Text;
        public string NpcName;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Image = parser.ReadColumn< uint >( 0 );
            Text = parser.ReadColumn< string >( 1 );
            NpcName = parser.ReadColumn< string >( 2 );
        }
    }
}