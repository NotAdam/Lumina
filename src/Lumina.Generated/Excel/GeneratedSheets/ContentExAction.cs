using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ContentExAction", columnHash: 0x8690a89e )]
    public class ContentExAction : IExcelRow
    {
        
        public LazyRow< Action > Name;
        public uint Unknown1;
        public byte Charges;
        public byte Unknown3;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Name = new LazyRow< Action >( lumina, parser.ReadColumn< uint >( 0 ), language );
            Unknown1 = parser.ReadColumn< uint >( 1 );
            Charges = parser.ReadColumn< byte >( 2 );
            Unknown3 = parser.ReadColumn< byte >( 3 );
        }
    }
}