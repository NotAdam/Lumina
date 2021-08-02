// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Pet", columnHash: 0x9c5824d1 )]
    public partial class Pet : ExcelRow
    {
        
        public SeString Name { get; set; }
        public ushort Unknown1 { get; set; }
        public ushort Unknown2 { get; set; }
        public ushort Unknown3 { get; set; }
        public ushort Unknown4 { get; set; }
        public ushort Unknown5 { get; set; }
        public bool Unknown6 { get; set; }
        public bool Unknown7 { get; set; }
        public bool Unknown8 { get; set; }
        public sbyte Unknown9 { get; set; }
        public byte Unknown10 { get; set; }
        public byte Unknown11 { get; set; }
        public byte Unknown12 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Name = parser.ReadColumn< SeString >( 0 );
            Unknown1 = parser.ReadColumn< ushort >( 1 );
            Unknown2 = parser.ReadColumn< ushort >( 2 );
            Unknown3 = parser.ReadColumn< ushort >( 3 );
            Unknown4 = parser.ReadColumn< ushort >( 4 );
            Unknown5 = parser.ReadColumn< ushort >( 5 );
            Unknown6 = parser.ReadColumn< bool >( 6 );
            Unknown7 = parser.ReadColumn< bool >( 7 );
            Unknown8 = parser.ReadColumn< bool >( 8 );
            Unknown9 = parser.ReadColumn< sbyte >( 9 );
            Unknown10 = parser.ReadColumn< byte >( 10 );
            Unknown11 = parser.ReadColumn< byte >( 11 );
            Unknown12 = parser.ReadColumn< byte >( 12 );
        }
    }
}