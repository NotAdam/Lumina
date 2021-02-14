// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "YKW", columnHash: 0x12e24636 )]
    public class YKW : ExcelRow
    {
        
        public ushort Unknown0;
        public LazyRow< Item > Item;
        public LazyRow< TerritoryType >[] Location;
        public SeString Unknown8;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Unknown0 = parser.ReadColumn< ushort >( 0 );
            Item = new LazyRow< Item >( lumina, parser.ReadColumn< uint >( 1 ), language );
            Location = new LazyRow< TerritoryType >[ 6 ];
            for( var i = 0; i < 6; i++ )
                Location[ i ] = new LazyRow< TerritoryType >( lumina, parser.ReadColumn< ushort >( 2 + i ), language );
            Unknown8 = parser.ReadColumn< SeString >( 8 );
        }
    }
}