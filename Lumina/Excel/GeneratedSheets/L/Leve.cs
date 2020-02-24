namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Leve", columnHash: 0x7e5dafa0 )]
    public class Leve : IExcelRow
    {
        // column defs from Wed, 15 Jan 2020 17:17:16 GMT

        /* offset: 0000 col: 0
         *  name: Name
         *  type: 
         */

        /* offset: 0004 col: 1
         *  name: Description
         *  type: 
         */

        /* offset: 0020 col: 2
         *  name: LeveClient
         *  type: 
         */

        /* offset: 0024 col: 3
         *  name: LeveAssignmentType
         *  type: 
         */

        /* offset: 0028 col: 4
         *  name: Town
         *  type: 
         */

        /* offset: 0050 col: 5
         *  name: ClassJobLevel
         *  type: 
         */

        /* offset: 0054 col: 6
         *  name: TimeLimit
         *  type: 
         */

        /* offset: 0055 col: 7
         *  name: AllowanceCost
         *  type: 
         */

        /* offset: 002c col: 8
         *  name: Evaluation
         *  type: 
         */

        /* offset: 0030 col: 9
         *  name: PlaceName{Start}
         *  type: 
         */

        /* offset: 0034 col: 10
         *  name: PlaceName{Issued}
         *  type: 
         */

        /* offset: 005a col: 11
         *  no SaintCoinach definition found
         */

        /* offset: 0056 col: 12
         *  name: ClassJobCategory
         *  type: 
         */

        /* offset: 0038 col: 13
         *  name: JournalGenre
         *  type: 
         */

        /* offset: 003c col: 14
         *  no SaintCoinach definition found
         */

        /* offset: 0040 col: 15
         *  name: PlaceName{StartZone}
         *  type: 
         */

        /* offset: 0044 col: 16
         *  name: Icon{CityState}
         *  type: 
         */

        /* offset: 0048 col: 17
         *  name: DataId
         *  type: 
         */

        /* offset: 005a col: 18
         *  name: CanCancel
         *  type: 
         */

        /* offset: 0057 col: 19
         *  name: MaxDifficulty
         *  type: 
         */

        /* offset: 0008 col: 20
         *  name: ExpFactor
         *  type: 
         */

        /* offset: 000c col: 21
         *  name: ExpReward
         *  type: 
         */

        /* offset: 0010 col: 22
         *  name: GilReward
         *  type: 
         */

        /* offset: 0014 col: 23
         *  name: LeveRewardItem
         *  type: 
         */

        /* offset: 0058 col: 24
         *  name: LeveVfx
         *  type: 
         */

        /* offset: 0059 col: 25
         *  name: LeveVfx{Frame}
         *  type: 
         */

        /* offset: 0018 col: 26
         *  name: Level{Levemete}
         *  type: 
         */

        /* offset: 004c col: 27
         *  name: Icon{Issuer}
         *  type: 
         */

        /* offset: 005a col: 28
         *  name: LockedLeve
         *  type: 
         */

        /* offset: 001c col: 29
         *  name: Level{Start}
         *  type: 
         */

        /* offset: 0052 col: 30
         *  name: BGM
         *  type: 
         */



        // col: 00 offset: 0000
        public string Name;

        // col: 01 offset: 0004
        public string Description;

        // col: 20 offset: 0008
        public float ExpFactor;

        // col: 21 offset: 000c
        public uint ExpReward;

        // col: 22 offset: 0010
        public uint GilReward;

        // col: 23 offset: 0014
        public ushort LeveRewardItem;

        // col: 26 offset: 0018
        public uint LevelLevemete;

        // col: 29 offset: 001c
        public uint LevelStart;

        // col: 02 offset: 0020
        public int LeveClient;

        // col: 03 offset: 0024
        public int LeveAssignmentType;

        // col: 04 offset: 0028
        public int Town;

        // col: 08 offset: 002c
        public int Evaluation;

        // col: 09 offset: 0030
        public int PlaceNameStart;

        // col: 10 offset: 0034
        public int PlaceNameIssued;

        // col: 13 offset: 0038
        public int JournalGenre;

        // col: 14 offset: 003c
        public int unknown3c;

        // col: 15 offset: 0040
        public int PlaceNameStartZone;

        // col: 16 offset: 0044
        public int IconCityState;

        // col: 17 offset: 0048
        public int DataId;

        // col: 27 offset: 004c
        public int IconIssuer;

        // col: 05 offset: 0050
        public ushort ClassJobLevel;

        // col: 30 offset: 0052
        public ushort BGM;

        // col: 06 offset: 0054
        public byte TimeLimit;

        // col: 07 offset: 0055
        public byte AllowanceCost;

        // col: 12 offset: 0056
        public byte ClassJobCategory;

        // col: 19 offset: 0057
        public byte MaxDifficulty;

        // col: 24 offset: 0058
        public byte LeveVfx;

        // col: 25 offset: 0059
        public byte LeveVfxFrame;

        // col: 11 offset: 005a
        private byte packed5a;
        public bool packed5a_1 => ( packed5a & 0x1 ) == 0x1;
        public bool CanCancel => ( packed5a & 0x2 ) == 0x2;
        public bool LockedLeve => ( packed5a & 0x4 ) == 0x4;


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

            // col: 20 offset: 0008
            ExpFactor = parser.ReadOffset< float >( 0x8 );

            // col: 21 offset: 000c
            ExpReward = parser.ReadOffset< uint >( 0xc );

            // col: 22 offset: 0010
            GilReward = parser.ReadOffset< uint >( 0x10 );

            // col: 23 offset: 0014
            LeveRewardItem = parser.ReadOffset< ushort >( 0x14 );

            // col: 26 offset: 0018
            LevelLevemete = parser.ReadOffset< uint >( 0x18 );

            // col: 29 offset: 001c
            LevelStart = parser.ReadOffset< uint >( 0x1c );

            // col: 2 offset: 0020
            LeveClient = parser.ReadOffset< int >( 0x20 );

            // col: 3 offset: 0024
            LeveAssignmentType = parser.ReadOffset< int >( 0x24 );

            // col: 4 offset: 0028
            Town = parser.ReadOffset< int >( 0x28 );

            // col: 8 offset: 002c
            Evaluation = parser.ReadOffset< int >( 0x2c );

            // col: 9 offset: 0030
            PlaceNameStart = parser.ReadOffset< int >( 0x30 );

            // col: 10 offset: 0034
            PlaceNameIssued = parser.ReadOffset< int >( 0x34 );

            // col: 13 offset: 0038
            JournalGenre = parser.ReadOffset< int >( 0x38 );

            // col: 14 offset: 003c
            unknown3c = parser.ReadOffset< int >( 0x3c );

            // col: 15 offset: 0040
            PlaceNameStartZone = parser.ReadOffset< int >( 0x40 );

            // col: 16 offset: 0044
            IconCityState = parser.ReadOffset< int >( 0x44 );

            // col: 17 offset: 0048
            DataId = parser.ReadOffset< int >( 0x48 );

            // col: 27 offset: 004c
            IconIssuer = parser.ReadOffset< int >( 0x4c );

            // col: 5 offset: 0050
            ClassJobLevel = parser.ReadOffset< ushort >( 0x50 );

            // col: 30 offset: 0052
            BGM = parser.ReadOffset< ushort >( 0x52 );

            // col: 6 offset: 0054
            TimeLimit = parser.ReadOffset< byte >( 0x54 );

            // col: 7 offset: 0055
            AllowanceCost = parser.ReadOffset< byte >( 0x55 );

            // col: 12 offset: 0056
            ClassJobCategory = parser.ReadOffset< byte >( 0x56 );

            // col: 19 offset: 0057
            MaxDifficulty = parser.ReadOffset< byte >( 0x57 );

            // col: 24 offset: 0058
            LeveVfx = parser.ReadOffset< byte >( 0x58 );

            // col: 25 offset: 0059
            LeveVfxFrame = parser.ReadOffset< byte >( 0x59 );

            // col: 11 offset: 005a
            packed5a = parser.ReadOffset< byte >( 0x5a );


        }
    }
}