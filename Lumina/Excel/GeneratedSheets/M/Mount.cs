using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Mount", columnHash: 0x3b2b9eb0 )]
    public class Mount : IExcelRow
    {
        // column defs from Wed, 15 Jan 2020 17:17:16 GMT


        // col: 00 offset: 0000
        public string Singular;

        // col: 02 offset: 0004
        public string Plural;

        // col: 01 offset: 0008
        public sbyte Adjective;

        // col: 03 offset: 0009
        public sbyte PossessivePronoun;

        // col: 04 offset: 000a
        public sbyte StartsWithVowel;

        // col: 05 offset: 000b
        public sbyte unknownb;

        // col: 06 offset: 000c
        public sbyte Pronoun;

        // col: 07 offset: 000d
        public sbyte Article;

        // col: 18 offset: 0010
        public string unknown10;

        // col: 19 offset: 0014
        public string unknown14;

        // col: 20 offset: 0018
        public string unknown18;

        // col: 08 offset: 001c
        public int ModelChara;

        // col: 25 offset: 0020
        public int EquipHead;

        // col: 26 offset: 0024
        public int EquipBody;

        // col: 27 offset: 0028
        public int EquipLeg;

        // col: 28 offset: 002c
        public int EquipFoot;

        // col: 09 offset: 0030
        public ushort unknown30;

        // col: 17 offset: 0032
        public ushort RideBGM;

        // col: 30 offset: 0034
        public ushort Icon;

        // col: 37 offset: 0036
        public ushort MountAction;

        // col: 29 offset: 0038
        public short Order;

        // col: 10 offset: 003a
        public byte FlyingCondition;

        // col: 11 offset: 003b
        public byte unknown3b;

        // col: 12 offset: 003c
        public byte unknown3c;

        // col: 13 offset: 003d
        public byte unknown3d;

        // col: 14 offset: 003e
        public byte IsFlying;

        // col: 15 offset: 003f
        public byte unknown3f;

        // col: 16 offset: 0040
        public byte MountCustomize;

        // col: 21 offset: 0041
        public byte ExitMoveDist;

        // col: 22 offset: 0042
        public byte ExitMoveSpeed;

        // col: 31 offset: 0043
        public byte UIPriority;

        // col: 32 offset: 0044
        public byte RadiusRate;

        // col: 33 offset: 0045
        public byte BaseMotionSpeed_Run;

        // col: 34 offset: 0046
        public byte BaseMotionSpeed_Walk;

        // col: 35 offset: 0047
        public byte unknown47;

        // col: 36 offset: 0048
        public byte ExtraSeats;

        // col: 43 offset: 0049
        public byte unknown49;

        // col: 44 offset: 004a
        public byte unknown4a;

        // col: 23 offset: 004b
        private byte packed4b;
        public bool packed4b_1 => ( packed4b & 0x1 ) == 0x1;
        public bool IsEmote => ( packed4b & 0x2 ) == 0x2;
        public bool IsAirborne => ( packed4b & 0x4 ) == 0x4;
        public bool ExHotbarEnableConfig => ( packed4b & 0x8 ) == 0x8;
        public bool UseEP => ( packed4b & 0x10 ) == 0x10;
        public bool packed4b_20 => ( packed4b & 0x20 ) == 0x20;
        public bool IsImmobile => ( packed4b & 0x40 ) == 0x40;


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

            // col: 1 offset: 0008
            Adjective = parser.ReadOffset< sbyte >( 0x8 );

            // col: 3 offset: 0009
            PossessivePronoun = parser.ReadOffset< sbyte >( 0x9 );

            // col: 4 offset: 000a
            StartsWithVowel = parser.ReadOffset< sbyte >( 0xa );

            // col: 5 offset: 000b
            unknownb = parser.ReadOffset< sbyte >( 0xb );

            // col: 6 offset: 000c
            Pronoun = parser.ReadOffset< sbyte >( 0xc );

            // col: 7 offset: 000d
            Article = parser.ReadOffset< sbyte >( 0xd );

            // col: 18 offset: 0010
            unknown10 = parser.ReadOffset< string >( 0x10 );

            // col: 19 offset: 0014
            unknown14 = parser.ReadOffset< string >( 0x14 );

            // col: 20 offset: 0018
            unknown18 = parser.ReadOffset< string >( 0x18 );

            // col: 8 offset: 001c
            ModelChara = parser.ReadOffset< int >( 0x1c );

            // col: 25 offset: 0020
            EquipHead = parser.ReadOffset< int >( 0x20 );

            // col: 26 offset: 0024
            EquipBody = parser.ReadOffset< int >( 0x24 );

            // col: 27 offset: 0028
            EquipLeg = parser.ReadOffset< int >( 0x28 );

            // col: 28 offset: 002c
            EquipFoot = parser.ReadOffset< int >( 0x2c );

            // col: 9 offset: 0030
            unknown30 = parser.ReadOffset< ushort >( 0x30 );

            // col: 17 offset: 0032
            RideBGM = parser.ReadOffset< ushort >( 0x32 );

            // col: 30 offset: 0034
            Icon = parser.ReadOffset< ushort >( 0x34 );

            // col: 37 offset: 0036
            MountAction = parser.ReadOffset< ushort >( 0x36 );

            // col: 29 offset: 0038
            Order = parser.ReadOffset< short >( 0x38 );

            // col: 10 offset: 003a
            FlyingCondition = parser.ReadOffset< byte >( 0x3a );

            // col: 11 offset: 003b
            unknown3b = parser.ReadOffset< byte >( 0x3b );

            // col: 12 offset: 003c
            unknown3c = parser.ReadOffset< byte >( 0x3c );

            // col: 13 offset: 003d
            unknown3d = parser.ReadOffset< byte >( 0x3d );

            // col: 14 offset: 003e
            IsFlying = parser.ReadOffset< byte >( 0x3e );

            // col: 15 offset: 003f
            unknown3f = parser.ReadOffset< byte >( 0x3f );

            // col: 16 offset: 0040
            MountCustomize = parser.ReadOffset< byte >( 0x40 );

            // col: 21 offset: 0041
            ExitMoveDist = parser.ReadOffset< byte >( 0x41 );

            // col: 22 offset: 0042
            ExitMoveSpeed = parser.ReadOffset< byte >( 0x42 );

            // col: 31 offset: 0043
            UIPriority = parser.ReadOffset< byte >( 0x43 );

            // col: 32 offset: 0044
            RadiusRate = parser.ReadOffset< byte >( 0x44 );

            // col: 33 offset: 0045
            BaseMotionSpeed_Run = parser.ReadOffset< byte >( 0x45 );

            // col: 34 offset: 0046
            BaseMotionSpeed_Walk = parser.ReadOffset< byte >( 0x46 );

            // col: 35 offset: 0047
            unknown47 = parser.ReadOffset< byte >( 0x47 );

            // col: 36 offset: 0048
            ExtraSeats = parser.ReadOffset< byte >( 0x48 );

            // col: 43 offset: 0049
            unknown49 = parser.ReadOffset< byte >( 0x49 );

            // col: 44 offset: 004a
            unknown4a = parser.ReadOffset< byte >( 0x4a );

            // col: 23 offset: 004b
            packed4b = parser.ReadOffset< byte >( 0x4b, ExcelColumnDataType.UInt8 );


        }
    }
}