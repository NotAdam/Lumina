// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "SatisfactionArbitration", columnHash: 0x3f77b2e9 )]
    public class SatisfactionArbitration : IExcelRow
    {
        
        public byte Unknown0;
        public byte Unknown1;
        public LazyRow< Quest > Quest;
        public byte Unknown3;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Unknown0 = parser.ReadColumn< byte >( 0 );
            Unknown1 = parser.ReadColumn< byte >( 1 );
            Quest = new LazyRow< Quest >( lumina, parser.ReadColumn< uint >( 2 ), language );
            Unknown3 = parser.ReadColumn< byte >( 3 );
        }
    }
}