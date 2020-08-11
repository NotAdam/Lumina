// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ActionCastVFX", columnHash: 0xd870e208 )]
    public class ActionCastVFX : IExcelRow
    {
        
        public LazyRow< VFX > VFX;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            VFX = new LazyRow< VFX >( lumina, parser.ReadColumn< ushort >( 0 ), language );
        }
    }
}