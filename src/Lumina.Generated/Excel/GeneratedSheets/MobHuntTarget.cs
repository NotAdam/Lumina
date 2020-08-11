// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MobHuntTarget", columnHash: 0x83a7f541 )]
    public class MobHuntTarget : IExcelRow
    {
        
        public LazyRow< BNpcName > Name;
        public LazyRow< Fate > FATE;
        public uint Icon;
        public LazyRow< Map > TerritoryType;
        public LazyRow< PlaceName > PlaceName;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Name = new LazyRow< BNpcName >( lumina, parser.ReadColumn< ushort >( 0 ), language );
            FATE = new LazyRow< Fate >( lumina, parser.ReadColumn< ushort >( 1 ), language );
            Icon = parser.ReadColumn< uint >( 2 );
            TerritoryType = new LazyRow< Map >( lumina, parser.ReadColumn< ushort >( 3 ), language );
            PlaceName = new LazyRow< PlaceName >( lumina, parser.ReadColumn< ushort >( 4 ), language );
        }
    }
}