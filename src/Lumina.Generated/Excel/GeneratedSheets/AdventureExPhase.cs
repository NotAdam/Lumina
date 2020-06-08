using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "AdventureExPhase", columnHash: 0x2ebeea9f )]
    public class AdventureExPhase : IExcelRow
    {
        
        public LazyRow< Quest > Quest;
        public LazyRow< Adventure > AdventureBegin;
        public LazyRow< Adventure > AdventureEnd;
        public byte Unknown3;
        public uint Unknown4;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Quest = new LazyRow< Quest >( lumina, parser.ReadColumn< uint >( 0 ) );
            AdventureBegin = new LazyRow< Adventure >( lumina, parser.ReadColumn< uint >( 1 ) );
            AdventureEnd = new LazyRow< Adventure >( lumina, parser.ReadColumn< uint >( 2 ) );
            Unknown3 = parser.ReadColumn< byte >( 3 );
            Unknown4 = parser.ReadColumn< uint >( 4 );
        }
    }
}