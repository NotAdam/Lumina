// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ActionCastTimeline", columnHash: 0x2020acf6 )]
    public partial class ActionCastTimeline : ExcelRow
    {
        
        public LazyRow< ActionTimeline > Name { get; set; }
        public LazyRow< VFX > VFX { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Name = new LazyRow< ActionTimeline >( gameData, parser.ReadColumn< ushort >( 0 ), language );
            VFX = new LazyRow< VFX >( gameData, parser.ReadColumn< ushort >( 1 ), language );
        }
    }
}