// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MiniGameRA", columnHash: 0xf22d339e )]
    public partial class MiniGameRA : ExcelRow
    {
        
        public int Unknown0 { get; set; }
        public int Icon { get; set; }
        public int Image { get; set; }
        public LazyRow< BGM > BGM { get; set; }
        public int Unknown4 { get; set; }
        public bool Unknown5 { get; set; }
        public uint Unknown6 { get; set; }
        public bool Unknown7 { get; set; }
        public bool Unknown8 { get; set; }
        public bool Unknown9 { get; set; }
        public ushort Unknown10 { get; set; }
        public ushort Unknown11 { get; set; }
        public ushort Unknown12 { get; set; }
        public short Unknown13 { get; set; }
        public short Unknown14 { get; set; }
        public short Unknown15 { get; set; }
        public short Unknown16 { get; set; }
        public byte Unknown17 { get; set; }
        public byte Unknown18 { get; set; }
        public byte Unknown19 { get; set; }
        public byte Unknown20 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< int >( 0 );
            Icon = parser.ReadColumn< int >( 1 );
            Image = parser.ReadColumn< int >( 2 );
            BGM = new LazyRow< BGM >( gameData, parser.ReadColumn< int >( 3 ), language );
            Unknown4 = parser.ReadColumn< int >( 4 );
            Unknown5 = parser.ReadColumn< bool >( 5 );
            Unknown6 = parser.ReadColumn< uint >( 6 );
            Unknown7 = parser.ReadColumn< bool >( 7 );
            Unknown8 = parser.ReadColumn< bool >( 8 );
            Unknown9 = parser.ReadColumn< bool >( 9 );
            Unknown10 = parser.ReadColumn< ushort >( 10 );
            Unknown11 = parser.ReadColumn< ushort >( 11 );
            Unknown12 = parser.ReadColumn< ushort >( 12 );
            Unknown13 = parser.ReadColumn< short >( 13 );
            Unknown14 = parser.ReadColumn< short >( 14 );
            Unknown15 = parser.ReadColumn< short >( 15 );
            Unknown16 = parser.ReadColumn< short >( 16 );
            Unknown17 = parser.ReadColumn< byte >( 17 );
            Unknown18 = parser.ReadColumn< byte >( 18 );
            Unknown19 = parser.ReadColumn< byte >( 19 );
            Unknown20 = parser.ReadColumn< byte >( 20 );
        }
    }
}