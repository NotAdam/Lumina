// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "BNpcState", columnHash: 0x439de63e )]
    public partial class BNpcState : ExcelRow
    {
        
        public byte Slot { get; set; }
        public sbyte OverRay { get; set; }
        public sbyte Unknown2 { get; set; }
        public byte Unknown3 { get; set; }
        public ushort Idle { get; set; }
        public byte Attribute0 { get; set; }
        public bool AttributeFlag0 { get; set; }
        public byte Attribute1 { get; set; }
        public bool AttributeFlag1 { get; set; }
        public byte Attribute2 { get; set; }
        public bool AttributeFlag2 { get; set; }
        public float Scale { get; set; }
        public byte Unknown12 { get; set; }
        public int LoopTimeline { get; set; }
        public bool Unknown14 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Slot = parser.ReadColumn< byte >( 0 );
            OverRay = parser.ReadColumn< sbyte >( 1 );
            Unknown2 = parser.ReadColumn< sbyte >( 2 );
            Unknown3 = parser.ReadColumn< byte >( 3 );
            Idle = parser.ReadColumn< ushort >( 4 );
            Attribute0 = parser.ReadColumn< byte >( 5 );
            AttributeFlag0 = parser.ReadColumn< bool >( 6 );
            Attribute1 = parser.ReadColumn< byte >( 7 );
            AttributeFlag1 = parser.ReadColumn< bool >( 8 );
            Attribute2 = parser.ReadColumn< byte >( 9 );
            AttributeFlag2 = parser.ReadColumn< bool >( 10 );
            Scale = parser.ReadColumn< float >( 11 );
            Unknown12 = parser.ReadColumn< byte >( 12 );
            LoopTimeline = parser.ReadColumn< int >( 13 );
            Unknown14 = parser.ReadColumn< bool >( 14 );
        }
    }
}