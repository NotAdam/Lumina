// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HousingEmploymentNpcList", columnHash: 0x6195119b )]
    public partial class HousingEmploymentNpcList : ExcelRow
    {
        
        public LazyRow< HousingEmploymentNpcRace > Race { get; set; }
        public LazyRow< ENpcBase >[] ENpcBase { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Race = new LazyRow< HousingEmploymentNpcRace >( gameData, parser.ReadColumn< byte >( 0 ), language );
            ENpcBase = new LazyRow< ENpcBase >[ 2 ];
            for( var i = 0; i < 2; i++ )
                ENpcBase[ i ] = new LazyRow< ENpcBase >( gameData, parser.ReadColumn< uint >( 1 + i ), language );
        }
    }
}