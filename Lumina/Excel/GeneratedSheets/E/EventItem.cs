using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "EventItem", columnHash: 0x2a1d4fb2 )]
    public class EventItem : IExcelRow
    {
        // column defs from Wed, 15 Jan 2020 17:17:16 GMT


        // col: 00 offset: 0000
        public string Singular;

        // col: 02 offset: 0004
        public string Plural;

        // col: 09 offset: 0008
        public string Name;

        // col: 01 offset: 000c
        public sbyte Adjective;

        // col: 03 offset: 000d
        public sbyte PossessivePronoun;

        // col: 04 offset: 000e
        public sbyte StartsWithVowel;

        // col: 05 offset: 000f
        public sbyte unknownf;

        // col: 06 offset: 0010
        public sbyte Pronoun;

        // col: 07 offset: 0011
        public sbyte Article;

        // col: 08 offset: 0012
        private byte packed12;
        public bool packed12_1 => ( packed12 & 0x1 ) == 0x1;

        // col: 14 offset: 0014
        public uint Quest;

        // col: 10 offset: 0018
        public ushort Icon;

        // col: 11 offset: 001a
        public ushort Action;

        // col: 12 offset: 001c
        public byte StackSize;

        // col: 13 offset: 001d
        public byte unknown1d;

        // col: 15 offset: 001e
        public byte CastTime;

        // col: 16 offset: 001f
        public byte CastTimeline;

        // col: 17 offset: 0020
        public byte Timeline;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Singular = parser.ReadOffset< string >( 0x0 );

            // col: 2 offset: 0004
            Plural = parser.ReadOffset< string >( 0x4 );

            // col: 9 offset: 0008
            Name = parser.ReadOffset< string >( 0x8 );

            // col: 1 offset: 000c
            Adjective = parser.ReadOffset< sbyte >( 0xc );

            // col: 3 offset: 000d
            PossessivePronoun = parser.ReadOffset< sbyte >( 0xd );

            // col: 4 offset: 000e
            StartsWithVowel = parser.ReadOffset< sbyte >( 0xe );

            // col: 5 offset: 000f
            unknownf = parser.ReadOffset< sbyte >( 0xf );

            // col: 6 offset: 0010
            Pronoun = parser.ReadOffset< sbyte >( 0x10 );

            // col: 7 offset: 0011
            Article = parser.ReadOffset< sbyte >( 0x11 );

            // col: 8 offset: 0012
            packed12 = parser.ReadOffset< byte >( 0x12, ExcelColumnDataType.UInt8 );

            // col: 14 offset: 0014
            Quest = parser.ReadOffset< uint >( 0x14 );

            // col: 10 offset: 0018
            Icon = parser.ReadOffset< ushort >( 0x18 );

            // col: 11 offset: 001a
            Action = parser.ReadOffset< ushort >( 0x1a );

            // col: 12 offset: 001c
            StackSize = parser.ReadOffset< byte >( 0x1c );

            // col: 13 offset: 001d
            unknown1d = parser.ReadOffset< byte >( 0x1d );

            // col: 15 offset: 001e
            CastTime = parser.ReadOffset< byte >( 0x1e );

            // col: 16 offset: 001f
            CastTimeline = parser.ReadOffset< byte >( 0x1f );

            // col: 17 offset: 0020
            Timeline = parser.ReadOffset< byte >( 0x20 );


        }
    }
}