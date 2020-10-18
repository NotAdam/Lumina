// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "UIColor", columnHash: 0x05bcd0de )]
    public class UIColor : IExcelRow
    {
        
        public uint UIForeground;
        public uint UIGlow;
        public uint Unknown2;
        public uint Unknown3;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            UIForeground = parser.ReadColumn< uint >( 0 );
            UIGlow = parser.ReadColumn< uint >( 1 );
            Unknown2 = parser.ReadColumn< uint >( 2 );
            Unknown3 = parser.ReadColumn< uint >( 3 );
        }
    }
}