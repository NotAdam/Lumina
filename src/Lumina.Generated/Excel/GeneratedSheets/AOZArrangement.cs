using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "AOZArrangement", columnHash: 0x2020acf6 )]
    public class AOZArrangement : IExcelRow
    {
        
        public LazyRow< AOZContentBriefingBNpc > AOZContentBriefingBNpc;
        public ushort Unknown1;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            AOZContentBriefingBNpc = new LazyRow< AOZContentBriefingBNpc >( lumina, parser.ReadColumn< ushort >( 0 ), language );
            Unknown1 = parser.ReadColumn< ushort >( 1 );
        }
    }
}