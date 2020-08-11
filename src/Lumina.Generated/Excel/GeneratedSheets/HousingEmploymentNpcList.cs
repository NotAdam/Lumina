// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HousingEmploymentNpcList", columnHash: 0x6195119b )]
    public class HousingEmploymentNpcList : IExcelRow
    {
        
        public LazyRow< HousingEmploymentNpcRace > Race;
        public LazyRow< ENpcBase >[] ENpcBase;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Race = new LazyRow< HousingEmploymentNpcRace >( lumina, parser.ReadColumn< byte >( 0 ), language );
            ENpcBase = new LazyRow< ENpcBase >[ 2 ];
            for( var i = 0; i < 2; i++ )
                ENpcBase[ i ] = new LazyRow< ENpcBase >( lumina, parser.ReadColumn< uint >( 1 + i ), language );
        }
    }
}