// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DescriptionPage", columnHash: 0xe721cad2 )]
    public class DescriptionPage : ExcelRow
    {
        
        public LazyRow< Quest > Quest { get; set; }
        public LazyRow< DescriptionString > Text1 { get; set; }
        public byte Image1 { get; set; }
        public LazyRow< DescriptionString > Text2 { get; set; }
        public uint Image2 { get; set; }
        public LazyRow< DescriptionString > Text3 { get; set; }
        public uint Image3 { get; set; }
        public LazyRow< DescriptionString > Text4 { get; set; }
        public uint Image4 { get; set; }
        public LazyRow< DescriptionString > Text5 { get; set; }
        public uint Image5 { get; set; }
        public LazyRow< DescriptionString > Text6 { get; set; }
        public uint Image6 { get; set; }
        public LazyRow< DescriptionString > Text7 { get; set; }
        public uint Image7 { get; set; }
        public LazyRow< DescriptionString > Text8 { get; set; }
        public uint Image8 { get; set; }
        public LazyRow< DescriptionString > Text9 { get; set; }
        public uint Image9 { get; set; }
        public ushort Unknown19 { get; set; }
        public uint Unknown20 { get; set; }
        public ushort Unknown21 { get; set; }
        public uint Unknown22 { get; set; }
        public ushort Unknown23 { get; set; }
        public uint Unknown24 { get; set; }
        public ushort Unknown25 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Quest = new LazyRow< Quest >( gameData, parser.ReadColumn< byte >( 0 ), language );
            Text1 = new LazyRow< DescriptionString >( gameData, parser.ReadColumn< uint >( 1 ), language );
            Image1 = parser.ReadColumn< byte >( 2 );
            Text2 = new LazyRow< DescriptionString >( gameData, parser.ReadColumn< ushort >( 3 ), language );
            Image2 = parser.ReadColumn< uint >( 4 );
            Text3 = new LazyRow< DescriptionString >( gameData, parser.ReadColumn< ushort >( 5 ), language );
            Image3 = parser.ReadColumn< uint >( 6 );
            Text4 = new LazyRow< DescriptionString >( gameData, parser.ReadColumn< ushort >( 7 ), language );
            Image4 = parser.ReadColumn< uint >( 8 );
            Text5 = new LazyRow< DescriptionString >( gameData, parser.ReadColumn< ushort >( 9 ), language );
            Image5 = parser.ReadColumn< uint >( 10 );
            Text6 = new LazyRow< DescriptionString >( gameData, parser.ReadColumn< ushort >( 11 ), language );
            Image6 = parser.ReadColumn< uint >( 12 );
            Text7 = new LazyRow< DescriptionString >( gameData, parser.ReadColumn< ushort >( 13 ), language );
            Image7 = parser.ReadColumn< uint >( 14 );
            Text8 = new LazyRow< DescriptionString >( gameData, parser.ReadColumn< ushort >( 15 ), language );
            Image8 = parser.ReadColumn< uint >( 16 );
            Text9 = new LazyRow< DescriptionString >( gameData, parser.ReadColumn< ushort >( 17 ), language );
            Image9 = parser.ReadColumn< uint >( 18 );
            Unknown19 = parser.ReadColumn< ushort >( 19 );
            Unknown20 = parser.ReadColumn< uint >( 20 );
            Unknown21 = parser.ReadColumn< ushort >( 21 );
            Unknown22 = parser.ReadColumn< uint >( 22 );
            Unknown23 = parser.ReadColumn< ushort >( 23 );
            Unknown24 = parser.ReadColumn< uint >( 24 );
            Unknown25 = parser.ReadColumn< ushort >( 25 );
        }
    }
}