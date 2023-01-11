// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "AchievementTarget", columnHash: 0x5bfa8a4e )]
    public partial class AchievementTarget : ExcelRow
    {
        
        public byte Type { get; set; }
        public uint Value { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Type = parser.ReadColumn< byte >( 0 );
            Value = parser.ReadColumn< uint >( 1 );
        }
    }
}