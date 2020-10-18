// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "PartyContent", columnHash: 0x54e6a214 )]
    public class PartyContent : IExcelRow
    {
        
        public byte Key;
        public ushort TimeLimit;
        public bool Name;
        public LazyRow< PartyContentTextData > TextDataStart;
        public LazyRow< PartyContentTextData > TextDataEnd;
        public uint Unknown5;
        public uint Unknown6;
        public uint Unknown7;
        public uint Unknown8;
        public uint Unknown9;
        public uint Unknown10;
        public uint Unknown11;
        public uint Unknown12;
        public uint Unknown13;
        public uint Unknown14;
        public uint Unknown15;
        public uint Unknown16;
        public uint Unknown17;
        public uint Unknown18;
        public uint Unknown19;
        public uint Unknown20;
        public uint Unknown21;
        public uint Unknown22;
        public uint Unknown23;
        public uint Unknown24;
        public uint Unknown25;
        public uint Unknown26;
        public uint Unknown27;
        public uint Unknown28;
        public uint Unknown29;
        public uint Unknown30;
        public uint Unknown31;
        public ushort Unknown32;
        public LazyRow< ContentFinderCondition > ContentFinderCondition;
        public uint Image;
        public byte Unknown35;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Key = parser.ReadColumn< byte >( 0 );
            TimeLimit = parser.ReadColumn< ushort >( 1 );
            Name = parser.ReadColumn< bool >( 2 );
            TextDataStart = new LazyRow< PartyContentTextData >( lumina, parser.ReadColumn< uint >( 3 ), language );
            TextDataEnd = new LazyRow< PartyContentTextData >( lumina, parser.ReadColumn< uint >( 4 ), language );
            Unknown5 = parser.ReadColumn< uint >( 5 );
            Unknown6 = parser.ReadColumn< uint >( 6 );
            Unknown7 = parser.ReadColumn< uint >( 7 );
            Unknown8 = parser.ReadColumn< uint >( 8 );
            Unknown9 = parser.ReadColumn< uint >( 9 );
            Unknown10 = parser.ReadColumn< uint >( 10 );
            Unknown11 = parser.ReadColumn< uint >( 11 );
            Unknown12 = parser.ReadColumn< uint >( 12 );
            Unknown13 = parser.ReadColumn< uint >( 13 );
            Unknown14 = parser.ReadColumn< uint >( 14 );
            Unknown15 = parser.ReadColumn< uint >( 15 );
            Unknown16 = parser.ReadColumn< uint >( 16 );
            Unknown17 = parser.ReadColumn< uint >( 17 );
            Unknown18 = parser.ReadColumn< uint >( 18 );
            Unknown19 = parser.ReadColumn< uint >( 19 );
            Unknown20 = parser.ReadColumn< uint >( 20 );
            Unknown21 = parser.ReadColumn< uint >( 21 );
            Unknown22 = parser.ReadColumn< uint >( 22 );
            Unknown23 = parser.ReadColumn< uint >( 23 );
            Unknown24 = parser.ReadColumn< uint >( 24 );
            Unknown25 = parser.ReadColumn< uint >( 25 );
            Unknown26 = parser.ReadColumn< uint >( 26 );
            Unknown27 = parser.ReadColumn< uint >( 27 );
            Unknown28 = parser.ReadColumn< uint >( 28 );
            Unknown29 = parser.ReadColumn< uint >( 29 );
            Unknown30 = parser.ReadColumn< uint >( 30 );
            Unknown31 = parser.ReadColumn< uint >( 31 );
            Unknown32 = parser.ReadColumn< ushort >( 32 );
            ContentFinderCondition = new LazyRow< ContentFinderCondition >( lumina, parser.ReadColumn< ushort >( 33 ), language );
            Image = parser.ReadColumn< uint >( 34 );
            Unknown35 = parser.ReadColumn< byte >( 35 );
        }
    }
}