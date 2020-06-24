using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ChocoboRaceStatus", columnHash: 0xf8ab135e )]
    public class ChocoboRaceStatus : IExcelRow
    {
        
        public LazyRow< Status > Status;
        public ushort Unknown1;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Status = new LazyRow< Status >( lumina, parser.ReadColumn< int >( 0 ), language );
            Unknown1 = parser.ReadColumn< ushort >( 1 );
        }
    }
}