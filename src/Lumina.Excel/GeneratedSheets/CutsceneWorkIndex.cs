// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CutsceneWorkIndex", columnHash: 0xd870e208 )]
    public partial class CutsceneWorkIndex : ExcelRow
    {
        
        public ushort WorkIndex { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            WorkIndex = parser.ReadColumn< ushort >( 0 );
        }
    }
}