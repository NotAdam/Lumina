// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "SharlayanCraftWorksSupply", columnHash: 0x903b128e )]
    public partial class SharlayanCraftWorksSupply : ExcelRow
    {
        
        public byte Unknown0 { get; set; }
        public byte Unknown1 { get; set; }
        public byte Unknown2 { get; set; }
        public byte Unknown3 { get; set; }
        public uint Unknown4 { get; set; }
        public uint Unknown5 { get; set; }
        public uint Unknown6 { get; set; }
        public uint Unknown7 { get; set; }
        public ushort Unknown8 { get; set; }
        public ushort Unknown9 { get; set; }
        public ushort Unknown10 { get; set; }
        public ushort Unknown11 { get; set; }
        public ushort Unknown12 { get; set; }
        public ushort Unknown13 { get; set; }
        public ushort Unknown14 { get; set; }
        public ushort Unknown15 { get; set; }
        public uint Unknown16 { get; set; }
        public uint Unknown17 { get; set; }
        public uint Unknown18 { get; set; }
        public uint Unknown19 { get; set; }
        public byte Unknown20 { get; set; }
        public byte Unknown21 { get; set; }
        public byte Unknown22 { get; set; }
        public byte Unknown23 { get; set; }
        public ushort Unknown24 { get; set; }
        public ushort Unknown25 { get; set; }
        public ushort Unknown26 { get; set; }
        public ushort Unknown27 { get; set; }
        public byte Unknown28 { get; set; }
        public byte Unknown29 { get; set; }
        public byte Unknown30 { get; set; }
        public byte Unknown31 { get; set; }
        public byte Unknown32 { get; set; }
        public byte Unknown33 { get; set; }
        public byte Unknown34 { get; set; }
        public byte Unknown35 { get; set; }
        public byte Unknown36 { get; set; }
        public byte Unknown37 { get; set; }
        public byte Unknown38 { get; set; }
        public byte Unknown39 { get; set; }
        public byte Unknown40 { get; set; }
        public byte Unknown41 { get; set; }
        public byte Unknown42 { get; set; }
        public byte Unknown43 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< byte >( 0 );
            Unknown1 = parser.ReadColumn< byte >( 1 );
            Unknown2 = parser.ReadColumn< byte >( 2 );
            Unknown3 = parser.ReadColumn< byte >( 3 );
            Unknown4 = parser.ReadColumn< uint >( 4 );
            Unknown5 = parser.ReadColumn< uint >( 5 );
            Unknown6 = parser.ReadColumn< uint >( 6 );
            Unknown7 = parser.ReadColumn< uint >( 7 );
            Unknown8 = parser.ReadColumn< ushort >( 8 );
            Unknown9 = parser.ReadColumn< ushort >( 9 );
            Unknown10 = parser.ReadColumn< ushort >( 10 );
            Unknown11 = parser.ReadColumn< ushort >( 11 );
            Unknown12 = parser.ReadColumn< ushort >( 12 );
            Unknown13 = parser.ReadColumn< ushort >( 13 );
            Unknown14 = parser.ReadColumn< ushort >( 14 );
            Unknown15 = parser.ReadColumn< ushort >( 15 );
            Unknown16 = parser.ReadColumn< uint >( 16 );
            Unknown17 = parser.ReadColumn< uint >( 17 );
            Unknown18 = parser.ReadColumn< uint >( 18 );
            Unknown19 = parser.ReadColumn< uint >( 19 );
            Unknown20 = parser.ReadColumn< byte >( 20 );
            Unknown21 = parser.ReadColumn< byte >( 21 );
            Unknown22 = parser.ReadColumn< byte >( 22 );
            Unknown23 = parser.ReadColumn< byte >( 23 );
            Unknown24 = parser.ReadColumn< ushort >( 24 );
            Unknown25 = parser.ReadColumn< ushort >( 25 );
            Unknown26 = parser.ReadColumn< ushort >( 26 );
            Unknown27 = parser.ReadColumn< ushort >( 27 );
            Unknown28 = parser.ReadColumn< byte >( 28 );
            Unknown29 = parser.ReadColumn< byte >( 29 );
            Unknown30 = parser.ReadColumn< byte >( 30 );
            Unknown31 = parser.ReadColumn< byte >( 31 );
            Unknown32 = parser.ReadColumn< byte >( 32 );
            Unknown33 = parser.ReadColumn< byte >( 33 );
            Unknown34 = parser.ReadColumn< byte >( 34 );
            Unknown35 = parser.ReadColumn< byte >( 35 );
            Unknown36 = parser.ReadColumn< byte >( 36 );
            Unknown37 = parser.ReadColumn< byte >( 37 );
            Unknown38 = parser.ReadColumn< byte >( 38 );
            Unknown39 = parser.ReadColumn< byte >( 39 );
            Unknown40 = parser.ReadColumn< byte >( 40 );
            Unknown41 = parser.ReadColumn< byte >( 41 );
            Unknown42 = parser.ReadColumn< byte >( 42 );
            Unknown43 = parser.ReadColumn< byte >( 43 );
        }
    }
}