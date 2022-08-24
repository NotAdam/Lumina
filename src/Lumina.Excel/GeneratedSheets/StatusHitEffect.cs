// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "StatusHitEffect", columnHash: 0xd870e208 )]
    public partial class StatusHitEffect : ExcelRow
    {
        
        public LazyRow< VFX > Location { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Location = new LazyRow< VFX >( gameData, parser.ReadColumn< ushort >( 0 ), language );
        }
    }
}