using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ScenarioTreeTips", columnHash: 0x71371b8c )]
    public class ScenarioTreeTips : IExcelRow
    {
        
        public byte Unknown0;
        public LazyRow< ScenarioTreeTipsQuest > Tips1;
        public ushort Unknown2;
        public LazyRow< ScenarioTree > Tips2;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Unknown0 = parser.ReadColumn< byte >( 0 );
            Tips1 = new LazyRow< ScenarioTreeTipsQuest >( lumina, parser.ReadColumn< uint >( 1 ) );
            Unknown2 = parser.ReadColumn< ushort >( 2 );
            Tips2 = new LazyRow< ScenarioTree >( lumina, parser.ReadColumn< uint >( 3 ) );
        }
    }
}