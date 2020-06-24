using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "PreHandler", columnHash: 0x121fc5dc )]
    public class PreHandler : IExcelRow
    {
        
        public uint Target;
        public byte Unknown1;
        public LazyRow< ActionTimeline > ActionTimeline;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Target = parser.ReadColumn< uint >( 0 );
            Unknown1 = parser.ReadColumn< byte >( 1 );
            ActionTimeline = new LazyRow< ActionTimeline >( lumina, parser.ReadColumn< ushort >( 2 ), language );
        }
    }
}