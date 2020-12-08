// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GoldSaucerArcadeMachine", columnHash: 0xacb73d9e )]
    public class GoldSaucerArcadeMachine : IExcelRow
    {
        
        public byte Unknown0;
        public byte Unknown1;
        public byte Unknown2;
        public byte Unknown3;
        public ushort Unknown4;
        public byte Unknown5;
        public uint FailImage;
        public sbyte Unknown7;
        public sbyte Unknown8;
        public sbyte Unknown9;
        public uint Unknown10;
        public byte Unknown11;
        public sbyte Unknown12;
        public sbyte Unknown13;
        public sbyte Unknown14;
        public byte Unknown15;
        public byte Unknown16;
        public byte Unknown17;
        public byte Unknown18;
        public byte Unknown19;
        public byte Unknown20;
        public byte Unknown21;
        public byte Unknown22;
        public byte Unknown23;
        public byte Unknown24;
        public byte Unknown25;
        public byte Unknown26;
        public uint Unknown27;
        public uint Unknown28;
        public uint Unknown29;
        public uint Unknown30;
        public byte Unknown31;
        public byte Unknown32;
        public byte Unknown33;
        public byte Unknown34;
        public uint Poor;
        public uint Good;
        public uint Great;
        public uint Excellent;
        public SeString Unknown39;
        public SeString Unknown40;
        public SeString Unknown41;
        public SeString Unknown42;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

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