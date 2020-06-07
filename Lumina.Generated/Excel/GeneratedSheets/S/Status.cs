using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Status", columnHash: 0xd8ae9831 )]
    public class Status : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public string Name;

        // col: 01 offset: 0004
        public string Description;

        // col: 02 offset: 0008
        public ushort Icon;

        // col: 23 offset: 000a
        public ushort Log;

        // col: 20 offset: 000c
        public short unknownc;

        // col: 03 offset: 000e
        public byte MaxStacks;

        // col: 04 offset: 000f
        public byte unknownf;

        // col: 05 offset: 0010
        public byte Category;

        // col: 06 offset: 0011
        public byte HitEffect;

        // col: 07 offset: 0012
        public byte VFX;

        // col: 17 offset: 0013
        public byte PartyListPriority;

        // col: 21 offset: 0014
        public byte unknown14;

        // col: 26 offset: 0015
        public byte unknown15;

        // col: 27 offset: 0016
        public byte unknown16;

        // col: 08 offset: 0017
        public bool LockMovement;
        public byte packed17;
        public bool packed17_2;
        public bool LockActions;
        public bool LockControl;
        public bool Transfiguration;
        public bool packed17_20;
        public bool CanDispel;
        public bool InflictedByActor;

        // col: 16 offset: 0018
        public bool IsPermanent;
        public byte packed18;
        public bool packed18_2;
        public bool packed18_4;
        public bool packed18_8;
        public bool IsFcBuff;
        public bool Invisibility;
        public bool packed18_40;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Name = parser.ReadOffset< string >( 0x0 );

            // col: 1 offset: 0004
            Description = parser.ReadOffset< string >( 0x4 );

            // col: 2 offset: 0008
            Icon = parser.ReadOffset< ushort >( 0x8 );

            // col: 23 offset: 000a
            Log = parser.ReadOffset< ushort >( 0xa );

            // col: 20 offset: 000c
            unknownc = parser.ReadOffset< short >( 0xc );

            // col: 3 offset: 000e
            MaxStacks = parser.ReadOffset< byte >( 0xe );

            // col: 4 offset: 000f
            unknownf = parser.ReadOffset< byte >( 0xf );

            // col: 5 offset: 0010
            Category = parser.ReadOffset< byte >( 0x10 );

            // col: 6 offset: 0011
            HitEffect = parser.ReadOffset< byte >( 0x11 );

            // col: 7 offset: 0012
            VFX = parser.ReadOffset< byte >( 0x12 );

            // col: 17 offset: 0013
            PartyListPriority = parser.ReadOffset< byte >( 0x13 );

            // col: 21 offset: 0014
            unknown14 = parser.ReadOffset< byte >( 0x14 );

            // col: 26 offset: 0015
            unknown15 = parser.ReadOffset< byte >( 0x15 );

            // col: 27 offset: 0016
            unknown16 = parser.ReadOffset< byte >( 0x16 );

            // col: 8 offset: 0017
            packed17 = parser.ReadOffset< byte >( 0x17, ExcelColumnDataType.UInt8 );

            LockMovement = ( packed17 & 0x1 ) == 0x1;
            packed17_2 = ( packed17 & 0x2 ) == 0x2;
            LockActions = ( packed17 & 0x4 ) == 0x4;
            LockControl = ( packed17 & 0x8 ) == 0x8;
            Transfiguration = ( packed17 & 0x10 ) == 0x10;
            packed17_20 = ( packed17 & 0x20 ) == 0x20;
            CanDispel = ( packed17 & 0x40 ) == 0x40;
            InflictedByActor = ( packed17 & 0x80 ) == 0x80;

            // col: 16 offset: 0018
            packed18 = parser.ReadOffset< byte >( 0x18, ExcelColumnDataType.UInt8 );

            IsPermanent = ( packed18 & 0x1 ) == 0x1;
            packed18_2 = ( packed18 & 0x2 ) == 0x2;
            packed18_4 = ( packed18 & 0x4 ) == 0x4;
            packed18_8 = ( packed18 & 0x8 ) == 0x8;
            IsFcBuff = ( packed18 & 0x10 ) == 0x10;
            Invisibility = ( packed18 & 0x20 ) == 0x20;
            packed18_40 = ( packed18 & 0x40 ) == 0x40;


        }
    }
}