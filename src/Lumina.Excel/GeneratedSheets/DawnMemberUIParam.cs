// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DawnMemberUIParam", columnHash: 0x7b44bc07 )]
    public partial class DawnMemberUIParam : ExcelRow
    {
        
        public SeString ClassSingular { get; set; }
        public SeString Unknown1 { get; set; }
        public uint VoiceLine { get; set; }
        public SeString ClassPlural { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            ClassSingular = parser.ReadColumn< SeString >( 0 );
            Unknown1 = parser.ReadColumn< SeString >( 1 );
            VoiceLine = parser.ReadColumn< uint >( 2 );
            ClassPlural = parser.ReadColumn< SeString >( 3 );
        }
    }
}