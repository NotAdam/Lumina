// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MoveVfx", columnHash: 0x2020acf6 )]
    public partial class MoveVfx : ExcelRow
    {
        
        public LazyRow< VFX > VFXNormal { get; set; }
        public LazyRow< VFX > VFXWalking { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            VFXNormal = new LazyRow< VFX >( gameData, parser.ReadColumn< ushort >( 0 ), language );
            VFXWalking = new LazyRow< VFX >( gameData, parser.ReadColumn< ushort >( 1 ), language );
        }
    }
}