using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "QuestClassJobSupply", columnHash: 0xdd620f3e )]
    public class QuestClassJobSupply : IExcelRow
    {
        
        public LazyRow< ClassJobCategory > ClassJobCategory;
        public byte Unknown1;
        public LazyRow< ENpcResident > ENpcResident;
        public LazyRow< Item > Item;
        public byte Unknown4;
        public bool Unknown5;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            ClassJobCategory = new LazyRow< ClassJobCategory >( lumina, parser.ReadColumn< byte >( 0 ) );
            Unknown1 = parser.ReadColumn< byte >( 1 );
            ENpcResident = new LazyRow< ENpcResident >( lumina, parser.ReadColumn< uint >( 2 ) );
            Item = new LazyRow< Item >( lumina, parser.ReadColumn< uint >( 3 ) );
            Unknown4 = parser.ReadColumn< byte >( 4 );
            Unknown5 = parser.ReadColumn< bool >( 5 );
        }
    }
}