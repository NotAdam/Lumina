// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MJIVillageDevelopment", columnHash: 0x22c914e4 )]
    public partial class MJIVillageDevelopment : ExcelRow
    {
        
        public uint Unknown0 { get; set; }
        public byte Unknown1 { get; set; }
        public byte Unknown2 { get; set; }
        public byte Unknown3 { get; set; }
        public uint Unknown4 { get; set; }
        public byte Unknown5 { get; set; }
        public uint Unknown6 { get; set; }
        public byte Unknown7 { get; set; }
        public uint Unknown8 { get; set; }
        public ushort Unknown9 { get; set; }
        public uint Unknown10 { get; set; }
        public ushort Unknown11 { get; set; }
        public uint Unknown12 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< uint >( 0 );
            Unknown1 = parser.ReadColumn< byte >( 1 );
            Unknown2 = parser.ReadColumn< byte >( 2 );
            Unknown3 = parser.ReadColumn< byte >( 3 );
            Unknown4 = parser.ReadColumn< uint >( 4 );
            Unknown5 = parser.ReadColumn< byte >( 5 );
            Unknown6 = parser.ReadColumn< uint >( 6 );
            Unknown7 = parser.ReadColumn< byte >( 7 );
            Unknown8 = parser.ReadColumn< uint >( 8 );
            Unknown9 = parser.ReadColumn< ushort >( 9 );
            Unknown10 = parser.ReadColumn< uint >( 10 );
            Unknown11 = parser.ReadColumn< ushort >( 11 );
            Unknown12 = parser.ReadColumn< uint >( 12 );
        }
    }
}