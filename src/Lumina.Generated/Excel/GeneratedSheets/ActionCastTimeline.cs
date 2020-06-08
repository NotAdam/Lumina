using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ActionCastTimeline", columnHash: 0x2020acf6 )]
    public class ActionCastTimeline : IExcelRow
    {
        
        public LazyRow< ActionTimeline > Name;
        public LazyRow< VFX > VFX;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Name = new LazyRow< ActionTimeline >( lumina, parser.ReadColumn< ushort >( 0 ) );
            VFX = new LazyRow< VFX >( lumina, parser.ReadColumn< ushort >( 1 ) );
        }
    }
}