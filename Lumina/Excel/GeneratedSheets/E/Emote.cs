using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Emote", columnHash: 0xc4735d67 )]
    public class Emote : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public string Name;

        // col: 22 offset: 0004
        public uint UnlockLink;

        // col: 18 offset: 0008
        public int TextCommand;

        // col: 01 offset: 000c
        public ushort[] ActionTimeline;

        // col: 17 offset: 001a
        public ushort unknown1a;

        // col: 19 offset: 001c
        public ushort Icon;

        // col: 20 offset: 001e
        public ushort LogMessageTargeted;

        // col: 21 offset: 0020
        public ushort LogMessageUntargeted;

        // col: 11 offset: 0022
        public byte EmoteCategory;

        // col: 12 offset: 0023
        public byte EmoteMode;

        // col: 08 offset: 0024
        public bool packed24_1;
        public byte packed24;
        public bool packed24_2;
        public bool packed24_4;
        public bool packed24_8;
        public bool packed24_10;
        public bool HasCancelEmote;
        public bool DrawsWeapon;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Name = parser.ReadOffset< string >( 0x0 );

            // col: 22 offset: 0004
            UnlockLink = parser.ReadOffset< uint >( 0x4 );

            // col: 18 offset: 0008
            TextCommand = parser.ReadOffset< int >( 0x8 );

            // col: 1 offset: 000c
            ActionTimeline = new ushort[7];
            ActionTimeline[0] = parser.ReadOffset< ushort >( 0xc );
            ActionTimeline[1] = parser.ReadOffset< ushort >( 0xe );
            ActionTimeline[2] = parser.ReadOffset< ushort >( 0x10 );
            ActionTimeline[3] = parser.ReadOffset< ushort >( 0x12 );
            ActionTimeline[4] = parser.ReadOffset< ushort >( 0x14 );
            ActionTimeline[5] = parser.ReadOffset< ushort >( 0x16 );
            ActionTimeline[6] = parser.ReadOffset< ushort >( 0x18 );

            // col: 17 offset: 001a
            unknown1a = parser.ReadOffset< ushort >( 0x1a );

            // col: 19 offset: 001c
            Icon = parser.ReadOffset< ushort >( 0x1c );

            // col: 20 offset: 001e
            LogMessageTargeted = parser.ReadOffset< ushort >( 0x1e );

            // col: 21 offset: 0020
            LogMessageUntargeted = parser.ReadOffset< ushort >( 0x20 );

            // col: 11 offset: 0022
            EmoteCategory = parser.ReadOffset< byte >( 0x22 );

            // col: 12 offset: 0023
            EmoteMode = parser.ReadOffset< byte >( 0x23 );

            // col: 8 offset: 0024
            packed24 = parser.ReadOffset< byte >( 0x24, ExcelColumnDataType.UInt8 );

            packed24_1 = ( packed24 & 0x1 ) == 0x1;
            packed24_2 = ( packed24 & 0x2 ) == 0x2;
            packed24_4 = ( packed24 & 0x4 ) == 0x4;
            packed24_8 = ( packed24 & 0x8 ) == 0x8;
            packed24_10 = ( packed24 & 0x10 ) == 0x10;
            HasCancelEmote = ( packed24 & 0x20 ) == 0x20;
            DrawsWeapon = ( packed24 & 0x40 ) == 0x40;


        }
    }
}