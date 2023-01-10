// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GoldSaucerArcadeMachine", columnHash: 0xacb73d9e )]
    public partial class GoldSaucerArcadeMachine : ExcelRow
    {
        
        public byte Unknown0 { get; set; }
        public byte Unknown1 { get; set; }
        public byte Unknown2 { get; set; }
        public byte Unknown3 { get; set; }
        public ushort Unknown4 { get; set; }
        public byte Unknown5 { get; set; }
        public uint FailImage { get; set; }
        public sbyte Unknown7 { get; set; }
        public sbyte Unknown8 { get; set; }
        public sbyte Unknown9 { get; set; }
        public uint Unknown10 { get; set; }
        public byte Unknown11 { get; set; }
        public sbyte Unknown12 { get; set; }
        public sbyte Unknown13 { get; set; }
        public sbyte Unknown14 { get; set; }
        public byte Unknown15 { get; set; }
        public byte Unknown16 { get; set; }
        public byte Unknown17 { get; set; }
        public byte Unknown18 { get; set; }
        public byte Unknown19 { get; set; }
        public byte Unknown20 { get; set; }
        public byte Unknown21 { get; set; }
        public byte Unknown22 { get; set; }
        public byte Unknown23 { get; set; }
        public byte Unknown24 { get; set; }
        public byte Unknown25 { get; set; }
        public byte Unknown26 { get; set; }
        public uint Unknown27 { get; set; }
        public uint Unknown28 { get; set; }
        public uint Unknown29 { get; set; }
        public uint Unknown30 { get; set; }
        public byte Unknown31 { get; set; }
        public byte Unknown32 { get; set; }
        public byte Unknown33 { get; set; }
        public byte Unknown34 { get; set; }
        public uint Poor { get; set; }
        public uint Good { get; set; }
        public uint Great { get; set; }
        public uint Excellent { get; set; }
        public SeString Unknown39 { get; set; }
        public SeString Unknown40 { get; set; }
        public SeString Unknown41 { get; set; }
        public SeString Unknown42 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< byte >( 0 );
            Unknown1 = parser.ReadColumn< byte >( 1 );
            Unknown2 = parser.ReadColumn< byte >( 2 );
            Unknown3 = parser.ReadColumn< byte >( 3 );
            Unknown4 = parser.ReadColumn< ushort >( 4 );
            Unknown5 = parser.ReadColumn< byte >( 5 );
            FailImage = parser.ReadColumn< uint >( 6 );
            Unknown7 = parser.ReadColumn< sbyte >( 7 );
            Unknown8 = parser.ReadColumn< sbyte >( 8 );
            Unknown9 = parser.ReadColumn< sbyte >( 9 );
            Unknown10 = parser.ReadColumn< uint >( 10 );
            Unknown11 = parser.ReadColumn< byte >( 11 );
            Unknown12 = parser.ReadColumn< sbyte >( 12 );
            Unknown13 = parser.ReadColumn< sbyte >( 13 );
            Unknown14 = parser.ReadColumn< sbyte >( 14 );
            Unknown15 = parser.ReadColumn< byte >( 15 );
            Unknown16 = parser.ReadColumn< byte >( 16 );
            Unknown17 = parser.ReadColumn< byte >( 17 );
            Unknown18 = parser.ReadColumn< byte >( 18 );
            Unknown19 = parser.ReadColumn< byte >( 19 );
            Unknown20 = parser.ReadColumn< byte >( 20 );
            Unknown21 = parser.ReadColumn< byte >( 21 );
            Unknown22 = parser.ReadColumn< byte >( 22 );
            Unknown23 = parser.ReadColumn< byte >( 23 );
            Unknown24 = parser.ReadColumn< byte >( 24 );
            Unknown25 = parser.ReadColumn< byte >( 25 );
            Unknown26 = parser.ReadColumn< byte >( 26 );
            Unknown27 = parser.ReadColumn< uint >( 27 );
            Unknown28 = parser.ReadColumn< uint >( 28 );
            Unknown29 = parser.ReadColumn< uint >( 29 );
            Unknown30 = parser.ReadColumn< uint >( 30 );
            Unknown31 = parser.ReadColumn< byte >( 31 );
            Unknown32 = parser.ReadColumn< byte >( 32 );
            Unknown33 = parser.ReadColumn< byte >( 33 );
            Unknown34 = parser.ReadColumn< byte >( 34 );
            Poor = parser.ReadColumn< uint >( 35 );
            Good = parser.ReadColumn< uint >( 36 );
            Great = parser.ReadColumn< uint >( 37 );
            Excellent = parser.ReadColumn< uint >( 38 );
            Unknown39 = parser.ReadColumn< SeString >( 39 );
            Unknown40 = parser.ReadColumn< SeString >( 40 );
            Unknown41 = parser.ReadColumn< SeString >( 41 );
            Unknown42 = parser.ReadColumn< SeString >( 42 );
        }
    }
}