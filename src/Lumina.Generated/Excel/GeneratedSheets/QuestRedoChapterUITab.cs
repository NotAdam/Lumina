// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "QuestRedoChapterUITab", columnHash: 0x198356e8 )]
    public class QuestRedoChapterUITab : IExcelRow
    {
        
        public byte Unknown0;
        public uint Icon1;
        public uint Icon2;
        public string Text;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Unknown0 = parser.ReadColumn< byte >( 0 );
            Icon1 = parser.ReadColumn< uint >( 1 );
            Icon2 = parser.ReadColumn< uint >( 2 );
            Text = parser.ReadColumn< string >( 3 );
        }
    }
}