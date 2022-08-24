// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "BGMSystemDefine", columnHash: 0xd16a1b6c )]
    public partial class BGMSystemDefine : ExcelRow
    {
        
        public float Define { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Define = parser.ReadColumn< float >( 0 );
        }
    }
}