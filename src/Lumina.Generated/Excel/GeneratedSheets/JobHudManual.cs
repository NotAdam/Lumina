using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "JobHudManual", columnHash: 0x21d1dec2 )]
    public class JobHudManual : IExcelRow
    {
        
        public byte Unknown0;
        public byte Unknown1;
        public LazyRow< Action > Action;
        public byte Unknown3;
        public uint Unknown4;
        public LazyRow< Guide > Guide;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Unknown0 = parser.ReadColumn< byte >( 0 );
            Unknown1 = parser.ReadColumn< byte >( 1 );
            Action = new LazyRow< Action >( lumina, parser.ReadColumn< uint >( 2 ), language );
            Unknown3 = parser.ReadColumn< byte >( 3 );
            Unknown4 = parser.ReadColumn< uint >( 4 );
            Guide = new LazyRow< Guide >( lumina, parser.ReadColumn< ushort >( 5 ), language );
        }
    }
}