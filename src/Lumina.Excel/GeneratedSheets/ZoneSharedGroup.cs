// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ZoneSharedGroup", columnHash: 0xfa71ca60 )]
    public partial class ZoneSharedGroup : ExcelRow
    {
        
        public uint LGBSharedGroup { get; set; }
        public byte Unknown1 { get; set; }
        public LazyRow< Quest > Quest0 { get; set; }
        public uint Seq0 { get; set; }
        public bool Unknown4 { get; set; }
        public byte Unknown5 { get; set; }
        public LazyRow< Quest > Quest1 { get; set; }
        public uint Seq1 { get; set; }
        public bool Unknown8 { get; set; }
        public byte Unknown9 { get; set; }
        public LazyRow< Quest > Quest2 { get; set; }
        public uint Seq2 { get; set; }
        public bool Unknown12 { get; set; }
        public byte Unknown13 { get; set; }
        public LazyRow< Quest > Quest3 { get; set; }
        public uint Seq3 { get; set; }
        public bool Unknown16 { get; set; }
        public byte Unknown17 { get; set; }
        public LazyRow< Quest > Quest4 { get; set; }
        public uint Seq4 { get; set; }
        public bool Unknown20 { get; set; }
        public byte Unknown21 { get; set; }
        public LazyRow< Quest > Quest5 { get; set; }
        public uint Seq5 { get; set; }
        public bool Unknown24 { get; set; }
        public byte Unknown25 { get; set; }
        public uint Unknown26 { get; set; }
        public uint Unknown27 { get; set; }
        public bool Unknown28 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            LGBSharedGroup = parser.ReadColumn< uint >( 0 );
            Unknown1 = parser.ReadColumn< byte >( 1 );
            Quest0 = new LazyRow< Quest >( gameData, parser.ReadColumn< uint >( 2 ), language );
            Seq0 = parser.ReadColumn< uint >( 3 );
            Unknown4 = parser.ReadColumn< bool >( 4 );
            Unknown5 = parser.ReadColumn< byte >( 5 );
            Quest1 = new LazyRow< Quest >( gameData, parser.ReadColumn< uint >( 6 ), language );
            Seq1 = parser.ReadColumn< uint >( 7 );
            Unknown8 = parser.ReadColumn< bool >( 8 );
            Unknown9 = parser.ReadColumn< byte >( 9 );
            Quest2 = new LazyRow< Quest >( gameData, parser.ReadColumn< uint >( 10 ), language );
            Seq2 = parser.ReadColumn< uint >( 11 );
            Unknown12 = parser.ReadColumn< bool >( 12 );
            Unknown13 = parser.ReadColumn< byte >( 13 );
            Quest3 = new LazyRow< Quest >( gameData, parser.ReadColumn< uint >( 14 ), language );
            Seq3 = parser.ReadColumn< uint >( 15 );
            Unknown16 = parser.ReadColumn< bool >( 16 );
            Unknown17 = parser.ReadColumn< byte >( 17 );
            Quest4 = new LazyRow< Quest >( gameData, parser.ReadColumn< uint >( 18 ), language );
            Seq4 = parser.ReadColumn< uint >( 19 );
            Unknown20 = parser.ReadColumn< bool >( 20 );
            Unknown21 = parser.ReadColumn< byte >( 21 );
            Quest5 = new LazyRow< Quest >( gameData, parser.ReadColumn< uint >( 22 ), language );
            Seq5 = parser.ReadColumn< uint >( 23 );
            Unknown24 = parser.ReadColumn< bool >( 24 );
            Unknown25 = parser.ReadColumn< byte >( 25 );
            Unknown26 = parser.ReadColumn< uint >( 26 );
            Unknown27 = parser.ReadColumn< uint >( 27 );
            Unknown28 = parser.ReadColumn< bool >( 28 );
        }
    }
}