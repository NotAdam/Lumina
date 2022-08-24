// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MJIGatheringObject", columnHash: 0x58500f54 )]
    public partial class MJIGatheringObject : ExcelRow
    {
        
        public SeString Unknown0 { get; set; }
        public sbyte Unknown1 { get; set; }
        public SeString Unknown2 { get; set; }
        public sbyte Unknown3 { get; set; }
        public sbyte Unknown4 { get; set; }
        public sbyte Unknown5 { get; set; }
        public sbyte Unknown6 { get; set; }
        public sbyte Unknown7 { get; set; }
        public ushort Unknown8 { get; set; }
        public bool Unknown9 { get; set; }
        public uint Unknown10 { get; set; }
        public uint Unknown11 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< SeString >( 0 );
            Unknown1 = parser.ReadColumn< sbyte >( 1 );
            Unknown2 = parser.ReadColumn< SeString >( 2 );
            Unknown3 = parser.ReadColumn< sbyte >( 3 );
            Unknown4 = parser.ReadColumn< sbyte >( 4 );
            Unknown5 = parser.ReadColumn< sbyte >( 5 );
            Unknown6 = parser.ReadColumn< sbyte >( 6 );
            Unknown7 = parser.ReadColumn< sbyte >( 7 );
            Unknown8 = parser.ReadColumn< ushort >( 8 );
            Unknown9 = parser.ReadColumn< bool >( 9 );
            Unknown10 = parser.ReadColumn< uint >( 10 );
            Unknown11 = parser.ReadColumn< uint >( 11 );
        }
    }
}