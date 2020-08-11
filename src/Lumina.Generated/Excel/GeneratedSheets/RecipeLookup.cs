// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "RecipeLookup", columnHash: 0xa708a4a0 )]
    public class RecipeLookup : IExcelRow
    {
        
        public LazyRow< Recipe > CRP;
        public LazyRow< Recipe > BSM;
        public LazyRow< Recipe > ARM;
        public LazyRow< Recipe > GSM;
        public LazyRow< Recipe > LTW;
        public LazyRow< Recipe > WVR;
        public LazyRow< Recipe > ALC;
        public LazyRow< Recipe > CUL;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            CRP = new LazyRow< Recipe >( lumina, parser.ReadColumn< ushort >( 0 ), language );
            BSM = new LazyRow< Recipe >( lumina, parser.ReadColumn< ushort >( 1 ), language );
            ARM = new LazyRow< Recipe >( lumina, parser.ReadColumn< ushort >( 2 ), language );
            GSM = new LazyRow< Recipe >( lumina, parser.ReadColumn< ushort >( 3 ), language );
            LTW = new LazyRow< Recipe >( lumina, parser.ReadColumn< ushort >( 4 ), language );
            WVR = new LazyRow< Recipe >( lumina, parser.ReadColumn< ushort >( 5 ), language );
            ALC = new LazyRow< Recipe >( lumina, parser.ReadColumn< ushort >( 6 ), language );
            CUL = new LazyRow< Recipe >( lumina, parser.ReadColumn< ushort >( 7 ), language );
        }
    }
}