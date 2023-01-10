// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "RacingChocoboNameInfo", columnHash: 0x171828cf )]
    public partial class RacingChocoboNameInfo : ExcelRow
    {
        
        public LazyRow< RacingChocoboNameCategory > RacingChocoboNameCategory { get; set; }
        public bool Unknown1 { get; set; }
        public bool Unknown2 { get; set; }
        public bool Unknown3 { get; set; }
        public bool Unknown4 { get; set; }
        public LazyRow< RacingChocoboName >[] Name { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            RacingChocoboNameCategory = new LazyRow< RacingChocoboNameCategory >( gameData, parser.ReadColumn< byte >( 0 ), language );
            Unknown1 = parser.ReadColumn< bool >( 1 );
            Unknown2 = parser.ReadColumn< bool >( 2 );
            Unknown3 = parser.ReadColumn< bool >( 3 );
            Unknown4 = parser.ReadColumn< bool >( 4 );
            Name = new LazyRow< RacingChocoboName >[ 3 ];
            for( var i = 0; i < 3; i++ )
                Name[ i ] = new LazyRow< RacingChocoboName >( gameData, parser.ReadColumn< ushort >( 5 + i ), language );
        }
    }
}