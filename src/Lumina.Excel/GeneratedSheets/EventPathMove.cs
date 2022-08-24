// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "EventPathMove", columnHash: 0xb5e8d87a )]
    public partial class EventPathMove : ExcelRow
    {
        
        public uint Unknown0 { get; set; }
        public ushort Unknown1 { get; set; }
        public bool Unknown2 { get; set; }
        public byte Unknown3 { get; set; }
        public ushort Unknown4 { get; set; }
        public uint Unknown5 { get; set; }
        public uint Unknown6 { get; set; }
        public uint Unknown7 { get; set; }
        public uint Unknown8 { get; set; }
        public uint Unknown9 { get; set; }
        public SeString Unknown10 { get; set; }
        public SeString Unknown11 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< uint >( 0 );
            Unknown1 = parser.ReadColumn< ushort >( 1 );
            Unknown2 = parser.ReadColumn< bool >( 2 );
            Unknown3 = parser.ReadColumn< byte >( 3 );
            Unknown4 = parser.ReadColumn< ushort >( 4 );
            Unknown5 = parser.ReadColumn< uint >( 5 );
            Unknown6 = parser.ReadColumn< uint >( 6 );
            Unknown7 = parser.ReadColumn< uint >( 7 );
            Unknown8 = parser.ReadColumn< uint >( 8 );
            Unknown9 = parser.ReadColumn< uint >( 9 );
            Unknown10 = parser.ReadColumn< SeString >( 10 );
            Unknown11 = parser.ReadColumn< SeString >( 11 );
        }
    }
}