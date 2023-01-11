// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "PerformGroup", columnHash: 0x5be005ad )]
    public partial class PerformGroup : ExcelRow
    {
        
        public LazyRow< Perform >[] Perform { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Perform = new LazyRow< Perform >[ 5 ];
            for( var i = 0; i < 5; i++ )
                Perform[ i ] = new LazyRow< Perform >( gameData, parser.ReadColumn< byte >( 0 + i ), language );
        }
    }
}