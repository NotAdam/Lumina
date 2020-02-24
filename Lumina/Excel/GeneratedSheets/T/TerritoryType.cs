namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "TerritoryType", columnHash: 0x7dff1ae4 )]
    public class TerritoryType : IExcelRow
    {
        // column defs from Wed, 15 Jan 2020 17:17:16 GMT

        /* offset: 0000 col: 0
         *  name: Name
         *  type: 
         */

        /* offset: 0004 col: 1
         *  name: Bg
         *  type: 
         */

        /* offset: 002c col: 2
         *  name: BattalionMode
         *  type: 
         */

        /* offset: 001c col: 3
         *  name: PlaceName{Region}
         *  type: 
         */

        /* offset: 001e col: 4
         *  name: PlaceName{Zone}
         *  type: 
         */

        /* offset: 0020 col: 5
         *  name: PlaceName
         *  type: 
         */

        /* offset: 0022 col: 6
         *  name: Map
         *  type: 
         */

        /* offset: 002d col: 7
         *  name: LoadingImage
         *  type: 
         */

        /* offset: 002e col: 8
         *  name: ExclusiveType
         *  type: 
         */

        /* offset: 002f col: 9
         *  name: TerritoryIntendedUse
         *  type: 
         */

        /* offset: 0024 col: 10
         *  no SaintCoinach definition found
         */

        /* offset: 0038 col: 11
         *  no SaintCoinach definition found
         */

        /* offset: 0030 col: 12
         *  name: WeatherRate
         *  type: 
         */

        /* offset: 0038 col: 13
         *  no SaintCoinach definition found
         */

        /* offset: 0031 col: 14
         *  no SaintCoinach definition found
         */

        /* offset: 0038 col: 15
         *  name: PCSearch
         *  type: 
         */

        /* offset: 0038 col: 16
         *  name: Stealth
         *  type: 
         */

        /* offset: 0038 col: 17
         *  name: Mount
         *  type: 
         */

        /* offset: 0038 col: 18
         *  no SaintCoinach definition found
         */

        /* offset: 0026 col: 19
         *  name: BGM
         *  type: 
         */

        /* offset: 000c col: 20
         *  name: PlaceName{Region}Icon
         *  type: 
         */

        /* offset: 0010 col: 21
         *  name: PlaceNameIcon
         *  type: 
         */

        /* offset: 0008 col: 22
         *  name: ArrayEventHandler
         *  type: 
         */

        /* offset: 0028 col: 23
         *  name: QuestBattle
         *  type: 
         */

        /* offset: 0014 col: 24
         *  name: Aetheryte
         *  type: 
         */

        /* offset: 0018 col: 25
         *  name: FixedTime
         *  type: 
         */

        /* offset: 002a col: 26
         *  name: Resident
         *  type: 
         */

        /* offset: 0037 col: 27
         *  name: AchievementIndex
         *  type: 
         */

        /* offset: 0038 col: 28
         *  name: IsPvpZone
         *  type: 
         */

        /* offset: 0032 col: 29
         *  no SaintCoinach definition found
         */

        /* offset: 0033 col: 30
         *  no SaintCoinach definition found
         */

        /* offset: 0034 col: 31
         *  no SaintCoinach definition found
         */

        /* offset: 0035 col: 32
         *  no SaintCoinach definition found
         */

        /* offset: 0038 col: 33
         *  no SaintCoinach definition found
         */

        /* offset: 0039 col: 34
         *  no SaintCoinach definition found
         */

        /* offset: 0036 col: 35
         *  no SaintCoinach definition found
         */

        /* offset: 0039 col: 36
         *  no SaintCoinach definition found
         */

        /* offset: 0039 col: 37
         *  no SaintCoinach definition found
         */



        // col: 00 offset: 0000
        public string Name;

        // col: 01 offset: 0004
        public string Bg;

        // col: 22 offset: 0008
        public uint ArrayEventHandler;

        // col: 20 offset: 000c
        public int PlaceNameRegionIcon;

        // col: 21 offset: 0010
        public int PlaceNameIcon;

        // col: 24 offset: 0014
        public int Aetheryte;

        // col: 25 offset: 0018
        public int FixedTime;

        // col: 03 offset: 001c
        public ushort PlaceNameRegion;

        // col: 04 offset: 001e
        public ushort PlaceNameZone;

        // col: 05 offset: 0020
        public ushort PlaceName;

        // col: 06 offset: 0022
        public ushort Map;

        // col: 10 offset: 0024
        public ushort unknown24;

        // col: 19 offset: 0026
        public ushort BGM;

        // col: 23 offset: 0028
        public ushort QuestBattle;

        // col: 26 offset: 002a
        public ushort Resident;

        // col: 02 offset: 002c
        public byte BattalionMode;

        // col: 07 offset: 002d
        public byte LoadingImage;

        // col: 08 offset: 002e
        public byte ExclusiveType;

        // col: 09 offset: 002f
        public byte TerritoryIntendedUse;

        // col: 12 offset: 0030
        public byte WeatherRate;

        // col: 14 offset: 0031
        public byte unknown31;

        // col: 29 offset: 0032
        public byte unknown32;

        // col: 30 offset: 0033
        public byte unknown33;

        // col: 31 offset: 0034
        public byte unknown34;

        // col: 32 offset: 0035
        public byte unknown35;

        // col: 35 offset: 0036
        public byte unknown36;

        // col: 27 offset: 0037
        public sbyte AchievementIndex;

        // col: 11 offset: 0038
        private byte packed38;
        public bool packed38_1 => ( packed38 & 0x1 ) == 0x1;
        public bool packed38_2 => ( packed38 & 0x2 ) == 0x2;
        public bool PCSearch => ( packed38 & 0x4 ) == 0x4;
        public bool Stealth => ( packed38 & 0x8 ) == 0x8;
        public bool Mount => ( packed38 & 0x10 ) == 0x10;
        public bool packed38_20 => ( packed38 & 0x20 ) == 0x20;
        public bool IsPvpZone => ( packed38 & 0x40 ) == 0x40;
        public bool packed38_80 => ( packed38 & 0x80 ) == 0x80;

        // col: 34 offset: 0039
        private byte packed39;
        public bool packed39_1 => ( packed39 & 0x1 ) == 0x1;
        public bool packed39_2 => ( packed39 & 0x2 ) == 0x2;
        public bool packed39_4 => ( packed39 & 0x4 ) == 0x4;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Name = parser.ReadOffset< string >( 0x0 );

            // col: 1 offset: 0004
            Bg = parser.ReadOffset< string >( 0x4 );

            // col: 22 offset: 0008
            ArrayEventHandler = parser.ReadOffset< uint >( 0x8 );

            // col: 20 offset: 000c
            PlaceNameRegionIcon = parser.ReadOffset< int >( 0xc );

            // col: 21 offset: 0010
            PlaceNameIcon = parser.ReadOffset< int >( 0x10 );

            // col: 24 offset: 0014
            Aetheryte = parser.ReadOffset< int >( 0x14 );

            // col: 25 offset: 0018
            FixedTime = parser.ReadOffset< int >( 0x18 );

            // col: 3 offset: 001c
            PlaceNameRegion = parser.ReadOffset< ushort >( 0x1c );

            // col: 4 offset: 001e
            PlaceNameZone = parser.ReadOffset< ushort >( 0x1e );

            // col: 5 offset: 0020
            PlaceName = parser.ReadOffset< ushort >( 0x20 );

            // col: 6 offset: 0022
            Map = parser.ReadOffset< ushort >( 0x22 );

            // col: 10 offset: 0024
            unknown24 = parser.ReadOffset< ushort >( 0x24 );

            // col: 19 offset: 0026
            BGM = parser.ReadOffset< ushort >( 0x26 );

            // col: 23 offset: 0028
            QuestBattle = parser.ReadOffset< ushort >( 0x28 );

            // col: 26 offset: 002a
            Resident = parser.ReadOffset< ushort >( 0x2a );

            // col: 2 offset: 002c
            BattalionMode = parser.ReadOffset< byte >( 0x2c );

            // col: 7 offset: 002d
            LoadingImage = parser.ReadOffset< byte >( 0x2d );

            // col: 8 offset: 002e
            ExclusiveType = parser.ReadOffset< byte >( 0x2e );

            // col: 9 offset: 002f
            TerritoryIntendedUse = parser.ReadOffset< byte >( 0x2f );

            // col: 12 offset: 0030
            WeatherRate = parser.ReadOffset< byte >( 0x30 );

            // col: 14 offset: 0031
            unknown31 = parser.ReadOffset< byte >( 0x31 );

            // col: 29 offset: 0032
            unknown32 = parser.ReadOffset< byte >( 0x32 );

            // col: 30 offset: 0033
            unknown33 = parser.ReadOffset< byte >( 0x33 );

            // col: 31 offset: 0034
            unknown34 = parser.ReadOffset< byte >( 0x34 );

            // col: 32 offset: 0035
            unknown35 = parser.ReadOffset< byte >( 0x35 );

            // col: 35 offset: 0036
            unknown36 = parser.ReadOffset< byte >( 0x36 );

            // col: 27 offset: 0037
            AchievementIndex = parser.ReadOffset< sbyte >( 0x37 );

            // col: 11 offset: 0038
            packed38 = parser.ReadOffset< byte >( 0x38 );

            // col: 34 offset: 0039
            packed39 = parser.ReadOffset< byte >( 0x39 );


        }
    }
}