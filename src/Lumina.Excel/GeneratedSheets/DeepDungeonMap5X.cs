// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DeepDungeonMap5X", columnHash: 0x64a88f98 )]
    public partial class DeepDungeonMap5X : ExcelRow
    {
        
        public LazyRow< DeepDungeonRoom >[] DeepDungeonRoom { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            DeepDungeonRoom = new LazyRow< DeepDungeonRoom >[ 5 ];
            for( var i = 0; i < 5; i++ )
                DeepDungeonRoom[ i ] = new LazyRow< DeepDungeonRoom >( gameData, parser.ReadColumn< ushort >( 0 + i ), language );
        }
    }
}