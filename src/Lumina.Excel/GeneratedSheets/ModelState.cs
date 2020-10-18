// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ModelState", columnHash: 0xd73eab80 )]
    public class ModelState : IExcelRow
    {
        
        public byte Unknown0;
        public LazyRow< ActionTimeline > Start;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Unknown0 = parser.ReadColumn< byte >( 0 );
            Start = new LazyRow< ActionTimeline >( lumina, parser.ReadColumn< ushort >( 1 ), language );
        }
    }
}