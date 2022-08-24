// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "QuestRepeatFlag", columnHash: 0xdbf43666 )]
    public partial class QuestRepeatFlag : ExcelRow
    {
        
        public uint Quest { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Quest = parser.ReadColumn< uint >( 0 );
        }
    }
}