using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ContentGauge", columnHash: 0xf678f7f7 )]
    public class ContentGauge : IExcelRow
    {
        
        public string Name;
        public LazyRow< ContentGaugeColor > Color;
        public bool Unknown2;
        public string TextString;
        public sbyte Unknown4;
        public sbyte Unknown5;
        public byte Unknown6;
        public sbyte Unknown7;
        public sbyte Unknown8;
        public byte Unknown9;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Name = parser.ReadColumn< string >( 0 );
            Color = new LazyRow< ContentGaugeColor >( lumina, parser.ReadColumn< byte >( 1 ) );
            Unknown2 = parser.ReadColumn< bool >( 2 );
            TextString = parser.ReadColumn< string >( 3 );
            Unknown4 = parser.ReadColumn< sbyte >( 4 );
            Unknown5 = parser.ReadColumn< sbyte >( 5 );
            Unknown6 = parser.ReadColumn< byte >( 6 );
            Unknown7 = parser.ReadColumn< sbyte >( 7 );
            Unknown8 = parser.ReadColumn< sbyte >( 8 );
            Unknown9 = parser.ReadColumn< byte >( 9 );
        }
    }
}