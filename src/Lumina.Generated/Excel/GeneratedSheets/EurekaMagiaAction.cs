using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "EurekaMagiaAction", columnHash: 0x5a516458 )]
    public class EurekaMagiaAction : IExcelRow
    {
        
        public LazyRow< Action > Action;
        public byte MaxUses;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Action = new LazyRow< Action >( lumina, parser.ReadColumn< uint >( 0 ) );
            MaxUses = parser.ReadColumn< byte >( 1 );
        }
    }
}