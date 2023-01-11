// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "PlantPotFlowerSeed", columnHash: 0x84d0ceef )]
    public partial class PlantPotFlowerSeed : ExcelRow
    {
        
        public uint[] SeedIcon { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            SeedIcon = new uint[ 9 ];
            for( var i = 0; i < 9; i++ )
                SeedIcon[ i ] = parser.ReadColumn< uint >( 0 + i );
        }
    }
}