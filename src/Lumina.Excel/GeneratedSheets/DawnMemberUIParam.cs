// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DawnMemberUIParam", columnHash: 0x0fd503c6 )]
    public class DawnMemberUIParam : ExcelRow
    {
        
        public SeString ClassSingular { get; set; }
        public uint VoiceLine { get; set; }
        public SeString ClassPlural { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            ClassSingular = parser.ReadColumn< SeString >( 0 );
            VoiceLine = parser.ReadColumn< uint >( 1 );
            ClassPlural = parser.ReadColumn< SeString >( 2 );
        }
    }
}