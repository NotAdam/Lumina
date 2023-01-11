// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "UIColor", columnHash: 0x05bcd0de )]
    public partial class UIColor : ExcelRow
    {
        
        public uint UIForeground { get; set; }
        public uint UIGlow { get; set; }
        public uint Unknown2 { get; set; }
        public uint Unknown3 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            UIForeground = parser.ReadColumn< uint >( 0 );
            UIGlow = parser.ReadColumn< uint >( 1 );
            Unknown2 = parser.ReadColumn< uint >( 2 );
            Unknown3 = parser.ReadColumn< uint >( 3 );
        }
    }
}