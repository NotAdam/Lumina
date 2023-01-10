// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ContentRouletteOpenRule", columnHash: 0x985449ce )]
    public partial class ContentRouletteOpenRule : ExcelRow
    {
        
        public bool Unknown0 { get; set; }
        public uint Type { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< bool >( 0 );
            Type = parser.ReadColumn< uint >( 1 );
        }
    }
}