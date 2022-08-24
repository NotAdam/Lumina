// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GroupPoseStampCategory", columnHash: 0x5eb59ccb )]
    public partial class GroupPoseStampCategory : ExcelRow
    {
        
        public byte Unknown0 { get; set; }
        public SeString Name { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< byte >( 0 );
            Name = parser.ReadColumn< SeString >( 1 );
        }
    }
}