using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MoveVfx", columnHash: 0x2020acf6 )]
    public class MoveVfx : IExcelRow
    {
        
        public LazyRow< VFX > VFXNormal;
        public LazyRow< VFX > VFXWalking;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            VFXNormal = new LazyRow< VFX >( lumina, parser.ReadColumn< ushort >( 0 ) );
            VFXWalking = new LazyRow< VFX >( lumina, parser.ReadColumn< ushort >( 1 ) );
        }
    }
}