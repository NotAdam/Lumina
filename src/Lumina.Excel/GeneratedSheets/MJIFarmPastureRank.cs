// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MJIFarmPastureRank", columnHash: 0x7157b32e )]
    public partial class MJIFarmPastureRank : ExcelRow
    {
        
        public uint[] SGB { get; set; }
        public uint Unknown4 { get; set; }
        public uint Unknown5 { get; set; }
        public uint Unknown6 { get; set; }
        public uint Unknown7 { get; set; }
        public uint Unknown8 { get; set; }
        public uint Unknown9 { get; set; }
        public uint Unknown10 { get; set; }
        public uint Unknown11 { get; set; }
        public uint Unknown12 { get; set; }
        public uint Unknown13 { get; set; }
        public uint Unknown14 { get; set; }
        public uint Unknown15 { get; set; }
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
        public byte Unknown27 { get; set; }
        public uint Unknown28 { get; set; }
        public uint Unknown29 { get; set; }
        public uint Unknown30 { get; set; }
        public uint Unknown31 { get; set; }
        public uint Unknown32 { get; set; }
        public uint Unknown33 { get; set; }
        public uint Unknown34 { get; set; }
        public uint Unknown35 { get; set; }
        public byte Unknown36 { get; set; }
        public byte Unknown37 { get; set; }
        public byte Unknown38 { get; set; }
        public byte Unknown39 { get; set; }
        public ushort Unknown40 { get; set; }
        public ushort Unknown41 { get; set; }
        public ushort Unknown42 { get; set; }
        public ushort Unknown43 { get; set; }
        public ushort Unknown44 { get; set; }
        public ushort Unknown45 { get; set; }
        public ushort Unknown46 { get; set; }
        public ushort Unknown47 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            SGB = new uint[ 4 ];
            for( var i = 0; i < 4; i++ )
                SGB[ i ] = parser.ReadColumn< uint >( 0 + i );
            Unknown4 = parser.ReadColumn< uint >( 4 );
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
            Unknown27 = parser.ReadColumn< byte >( 27 );
            Unknown28 = parser.ReadColumn< uint >( 28 );
            Unknown29 = parser.ReadColumn< uint >( 29 );
            Unknown30 = parser.ReadColumn< uint >( 30 );
            Unknown31 = parser.ReadColumn< uint >( 31 );
            Unknown32 = parser.ReadColumn< uint >( 32 );
            Unknown33 = parser.ReadColumn< uint >( 33 );
            Unknown34 = parser.ReadColumn< uint >( 34 );
            Unknown35 = parser.ReadColumn< uint >( 35 );
            Unknown36 = parser.ReadColumn< byte >( 36 );
            Unknown37 = parser.ReadColumn< byte >( 37 );
            Unknown38 = parser.ReadColumn< byte >( 38 );
            Unknown39 = parser.ReadColumn< byte >( 39 );
            Unknown40 = parser.ReadColumn< ushort >( 40 );
            Unknown41 = parser.ReadColumn< ushort >( 41 );
            Unknown42 = parser.ReadColumn< ushort >( 42 );
            Unknown43 = parser.ReadColumn< ushort >( 43 );
            Unknown44 = parser.ReadColumn< ushort >( 44 );
            Unknown45 = parser.ReadColumn< ushort >( 45 );
            Unknown46 = parser.ReadColumn< ushort >( 46 );
            Unknown47 = parser.ReadColumn< ushort >( 47 );
        }
    }
}