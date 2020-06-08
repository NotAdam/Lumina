using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "RacingChocoboNameInfo", columnHash: 0x171828cf )]
    public class RacingChocoboNameInfo : IExcelRow
    {
        
        public LazyRow< RacingChocoboNameCategory > RacingChocoboNameCategory;
        public bool Unknown1;
        public bool Unknown2;
        public bool Unknown3;
        public bool Unknown4;
        public ushort Unknown5;
        public ushort Unknown6;
        public ushort Unknown7;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            RacingChocoboNameCategory = new LazyRow< RacingChocoboNameCategory >( lumina, parser.ReadColumn< byte >( 0 ) );
            Unknown1 = parser.ReadColumn< bool >( 1 );
            Unknown2 = parser.ReadColumn< bool >( 2 );
            Unknown3 = parser.ReadColumn< bool >( 3 );
            Unknown4 = parser.ReadColumn< bool >( 4 );
            Unknown5 = parser.ReadColumn< ushort >( 5 );
            Unknown6 = parser.ReadColumn< ushort >( 6 );
            Unknown7 = parser.ReadColumn< ushort >( 7 );
        }
    }
}