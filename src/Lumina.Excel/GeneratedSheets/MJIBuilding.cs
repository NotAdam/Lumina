// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MJIBuilding", columnHash: 0x6d809733 )]
    public partial class MJIBuilding : ExcelRow
    {
        
        public byte Unknown0 { get; set; }
        public ushort Unknown1 { get; set; }
        public byte Unknown2 { get; set; }
        public byte Unknown3 { get; set; }
        public ushort Unknown4 { get; set; }
        public byte Unknown5 { get; set; }
        public ushort Unknown6 { get; set; }
        public byte Unknown7 { get; set; }
        public ushort Unknown8 { get; set; }
        public byte Unknown9 { get; set; }
        public ushort Unknown10 { get; set; }
        public byte Unknown11 { get; set; }
        public byte Unknown12 { get; set; }
        public byte Unknown13 { get; set; }
        public byte Unknown14 { get; set; }
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
        public byte Unknown27 { get; set; }
        public byte Unknown28 { get; set; }
        public uint Unknown29 { get; set; }
        public uint Unknown30 { get; set; }
        public uint Unknown31 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< byte >( 0 );
            Unknown1 = parser.ReadColumn< ushort >( 1 );
            Unknown2 = parser.ReadColumn< byte >( 2 );
            Unknown3 = parser.ReadColumn< byte >( 3 );
            Unknown4 = parser.ReadColumn< ushort >( 4 );
            Unknown5 = parser.ReadColumn< byte >( 5 );
            Unknown6 = parser.ReadColumn< ushort >( 6 );
            Unknown7 = parser.ReadColumn< byte >( 7 );
            Unknown8 = parser.ReadColumn< ushort >( 8 );
            Unknown9 = parser.ReadColumn< byte >( 9 );
            Unknown10 = parser.ReadColumn< ushort >( 10 );
            Unknown11 = parser.ReadColumn< byte >( 11 );
            Unknown12 = parser.ReadColumn< byte >( 12 );
            Unknown13 = parser.ReadColumn< byte >( 13 );
            Unknown14 = parser.ReadColumn< byte >( 14 );
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
            Unknown27 = parser.ReadColumn< byte >( 27 );
            Unknown28 = parser.ReadColumn< byte >( 28 );
            Unknown29 = parser.ReadColumn< uint >( 29 );
            Unknown30 = parser.ReadColumn< uint >( 30 );
            Unknown31 = parser.ReadColumn< uint >( 31 );
        }
    }
}