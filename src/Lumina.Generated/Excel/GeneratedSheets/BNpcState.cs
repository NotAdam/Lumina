using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "BNpcState", columnHash: 0x439de63e )]
    public class BNpcState : IExcelRow
    {
        
        public byte Slot;
        public sbyte OverRay;
        public sbyte Unknown2;
        public byte Unknown3;
        public ushort Idle;
        public byte Attribute0;
        public bool AttributeFlag0;
        public byte Attribute1;
        public bool AttributeFlag1;
        public byte Attribute2;
        public bool AttributeFlag2;
        public float Scale;
        public byte Unknown12;
        public int LoopTimeline;
        public bool Unknown14;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

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