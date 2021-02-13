// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MobHuntTarget", columnHash: 0x83a7f541 )]
    public class MobHuntTarget : ExcelRow
    {
        
        public LazyRow< BNpcName > Name;
        public LazyRow< Fate > FATE;
        public uint Icon;
        public LazyRow< Map > TerritoryType;
        public LazyRow< PlaceName > PlaceName;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Name = new LazyRow< BNpcName >( lumina, parser.ReadColumn< ushort >( 0 ), language );
            FATE = new LazyRow< Fate >( lumina, parser.ReadColumn< ushort >( 1 ), language );
            Icon = parser.ReadColumn< uint >( 2 );
            TerritoryType = new LazyRow< Map >( lumina, parser.ReadColumn< ushort >( 3 ), language );
            PlaceName = new LazyRow< PlaceName >( lumina, parser.ReadColumn< ushort >( 4 ), language );
        }
    }
}