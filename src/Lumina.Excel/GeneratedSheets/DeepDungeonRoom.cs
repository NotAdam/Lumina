// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DeepDungeonRoom", columnHash: 0x6be0e840 )]
    public partial class DeepDungeonRoom : ExcelRow
    {
        
        public LazyRow< Level >[] Level { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Level = new LazyRow< Level >[ 5 ];
            for( var i = 0; i < 5; i++ )
                Level[ i ] = new LazyRow< Level >( gameData, parser.ReadColumn< uint >( 0 + i ), language );
        }
    }
}