using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DescriptionPage", columnHash: 0xe7fa61e4 )]
    public class DescriptionPage : IExcelRow
    {
        
        public LazyRow< Quest > Quest;
        public LazyRow< DescriptionString > Text1;
        public uint Image1;
        public LazyRow< DescriptionString > Text2;
        public uint Image2;
        public LazyRow< DescriptionString > Text3;
        public uint Image3;
        public LazyRow< DescriptionString > Text4;
        public uint Image4;
        public LazyRow< DescriptionString > Text5;
        public uint Image5;
        public LazyRow< DescriptionString > Text6;
        public uint Image6;
        public LazyRow< DescriptionString > Text7;
        public uint Image7;
        public LazyRow< DescriptionString > Text8;
        public uint Image8;
        public LazyRow< DescriptionString > Text9;
        public uint Image9;
        public ushort Unknown19;
        public uint Unknown20;
        public ushort Unknown21;
        public uint Unknown22;
        public ushort Unknown23;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Quest = new LazyRow< Quest >( lumina, parser.ReadColumn< uint >( 0 ) );
            Text1 = new LazyRow< DescriptionString >( lumina, parser.ReadColumn< ushort >( 1 ) );
            Image1 = parser.ReadColumn< uint >( 2 );
            Text2 = new LazyRow< DescriptionString >( lumina, parser.ReadColumn< ushort >( 3 ) );
            Image2 = parser.ReadColumn< uint >( 4 );
            Text3 = new LazyRow< DescriptionString >( lumina, parser.ReadColumn< ushort >( 5 ) );
            Image3 = parser.ReadColumn< uint >( 6 );
            Text4 = new LazyRow< DescriptionString >( lumina, parser.ReadColumn< ushort >( 7 ) );
            Image4 = parser.ReadColumn< uint >( 8 );
            Text5 = new LazyRow< DescriptionString >( lumina, parser.ReadColumn< ushort >( 9 ) );
            Image5 = parser.ReadColumn< uint >( 10 );
            Text6 = new LazyRow< DescriptionString >( lumina, parser.ReadColumn< ushort >( 11 ) );
            Image6 = parser.ReadColumn< uint >( 12 );
            Text7 = new LazyRow< DescriptionString >( lumina, parser.ReadColumn< ushort >( 13 ) );
            Image7 = parser.ReadColumn< uint >( 14 );
            Text8 = new LazyRow< DescriptionString >( lumina, parser.ReadColumn< ushort >( 15 ) );
            Image8 = parser.ReadColumn< uint >( 16 );
            Text9 = new LazyRow< DescriptionString >( lumina, parser.ReadColumn< ushort >( 17 ) );
            Image9 = parser.ReadColumn< uint >( 18 );
            Unknown19 = parser.ReadColumn< ushort >( 19 );
            Unknown20 = parser.ReadColumn< uint >( 20 );
            Unknown21 = parser.ReadColumn< ushort >( 21 );
            Unknown22 = parser.ReadColumn< uint >( 22 );
            Unknown23 = parser.ReadColumn< ushort >( 23 );
        }
    }
}