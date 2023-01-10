// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "BannerPreset", columnHash: 0xeeca93f7 )]
    public partial class BannerPreset : ExcelRow
    {
        
        public float Unknown0 { get; set; }
        public float Unknown1 { get; set; }
        public float Unknown2 { get; set; }
        public float Unknown3 { get; set; }
        public float Unknown4 { get; set; }
        public float Unknown5 { get; set; }
        public short Unknown6 { get; set; }
        public byte Unknown7 { get; set; }
        public ushort Unknown8 { get; set; }
        public float Unknown9 { get; set; }
        public int Unknown10 { get; set; }
        public float Unknown11 { get; set; }
        public float Unknown12 { get; set; }
        public float Unknown13 { get; set; }
        public float Unknown14 { get; set; }
        public byte Unknown15 { get; set; }
        public byte Unknown16 { get; set; }
        public byte Unknown17 { get; set; }
        public byte Unknown18 { get; set; }
        public byte Unknown19 { get; set; }
        public short Unknown20 { get; set; }
        public short Unknown21 { get; set; }
        public byte Unknown22 { get; set; }
        public byte Unknown23 { get; set; }
        public byte Unknown24 { get; set; }
        public byte Unknown25 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< float >( 0 );
            Unknown1 = parser.ReadColumn< float >( 1 );
            Unknown2 = parser.ReadColumn< float >( 2 );
            Unknown3 = parser.ReadColumn< float >( 3 );
            Unknown4 = parser.ReadColumn< float >( 4 );
            Unknown5 = parser.ReadColumn< float >( 5 );
            Unknown6 = parser.ReadColumn< short >( 6 );
            Unknown7 = parser.ReadColumn< byte >( 7 );
            Unknown8 = parser.ReadColumn< ushort >( 8 );
            Unknown9 = parser.ReadColumn< float >( 9 );
            Unknown10 = parser.ReadColumn< int >( 10 );
            Unknown11 = parser.ReadColumn< float >( 11 );
            Unknown12 = parser.ReadColumn< float >( 12 );
            Unknown13 = parser.ReadColumn< float >( 13 );
            Unknown14 = parser.ReadColumn< float >( 14 );
            Unknown15 = parser.ReadColumn< byte >( 15 );
            Unknown16 = parser.ReadColumn< byte >( 16 );
            Unknown17 = parser.ReadColumn< byte >( 17 );
            Unknown18 = parser.ReadColumn< byte >( 18 );
            Unknown19 = parser.ReadColumn< byte >( 19 );
            Unknown20 = parser.ReadColumn< short >( 20 );
            Unknown21 = parser.ReadColumn< short >( 21 );
            Unknown22 = parser.ReadColumn< byte >( 22 );
            Unknown23 = parser.ReadColumn< byte >( 23 );
            Unknown24 = parser.ReadColumn< byte >( 24 );
            Unknown25 = parser.ReadColumn< byte >( 25 );
        }
    }
}