using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DeepDungeonStatus", columnHash: 0xdc23efe7 )]
    public class DeepDungeonStatus : IExcelRow
    {
        
        public LazyRow< ScreenImage > ScreenImage;
        public LazyRow< LogMessage > LogMessage;
        public LazyRow< DeepDungeonFloorEffectUI > Name;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            ScreenImage = new LazyRow< ScreenImage >( lumina, parser.ReadColumn< ushort >( 0 ) );
            LogMessage = new LazyRow< LogMessage >( lumina, parser.ReadColumn< ushort >( 1 ) );
            Name = new LazyRow< DeepDungeonFloorEffectUI >( lumina, parser.ReadColumn< ushort >( 2 ) );
        }
    }
}