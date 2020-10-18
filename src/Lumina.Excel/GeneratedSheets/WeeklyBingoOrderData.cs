// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "WeeklyBingoOrderData", columnHash: 0xe0f2b530 )]
    public class WeeklyBingoOrderData : IExcelRow
    {
        
        public uint Type;
        public uint Data;
        public byte Unknown2;
        public LazyRow< WeeklyBingoText > Text;
        public uint Icon;
        public byte Unknown5;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Type = parser.ReadColumn< uint >( 0 );
            Data = parser.ReadColumn< uint >( 1 );
            Unknown2 = parser.ReadColumn< byte >( 2 );
            Text = new LazyRow< WeeklyBingoText >( lumina, parser.ReadColumn< byte >( 3 ), language );
            Icon = parser.ReadColumn< uint >( 4 );
            Unknown5 = parser.ReadColumn< byte >( 5 );
        }
    }
}