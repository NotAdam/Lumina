// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CustomTalkDynamicIcon", columnHash: 0x5d58cc84 )]
    public class CustomTalkDynamicIcon : ExcelRow
    {
        
        public uint SmallIcon { get; set; }
        public uint LargeIcon { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            SmallIcon = parser.ReadColumn< uint >( 0 );
            LargeIcon = parser.ReadColumn< uint >( 1 );
        }
    }
}