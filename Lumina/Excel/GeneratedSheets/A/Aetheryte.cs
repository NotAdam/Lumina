namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Aetheryte", columnHash: 0xcd1e31a4 )]
    public class Aetheryte : IExcelRow
    {
        // column defs from Tue, 29 Oct 2019 18:54:30 GMT

        /* offset: 0000 col: 0
         *  name: Singular
         *  type: 
         */

        /* offset: 0008 col: 1
         *  name: Adjective
         *  type: 
         */

        /* offset: 0004 col: 2
         *  name: Plural
         *  type: 
         */

        /* offset: 0009 col: 3
         *  name: PossessivePronoun
         *  type: 
         */

        /* offset: 000a col: 4
         *  name: StartsWithVowel
         *  type: 
         */

        /* offset: 000b col: 5
         *  no SaintCoinach definition found
         */

        /* offset: 000c col: 6
         *  name: Pronoun
         *  type: 
         */

        /* offset: 000d col: 7
         *  name: Article
         *  type: 
         */

        /* offset: 0028 col: 8
         *  name: PlaceName
         *  type: 
         */

        /* offset: 002a col: 9
         *  name: AethernetName
         *  type: 
         */

        /* offset: 002c col: 10
         *  name: Territory
         *  type: 
         */

        /* offset: 0014 col: 11
         *  name: Level
         *  repeat count: 4
         */

        /* offset: 0018 col: 12
         *  no SaintCoinach definition found
         */

        /* offset: 001c col: 13
         *  no SaintCoinach definition found
         */

        /* offset: 0020 col: 14
         *  no SaintCoinach definition found
         */

        /* offset: 0036 col: 15
         *  name: IsAetheryte
         *  type: 
         */

        /* offset: 0010 col: 16
         *  no SaintCoinach definition found
         */

        /* offset: 0034 col: 17
         *  name: AethernetGroup
         *  type: 
         */

        /* offset: 0036 col: 18
         *  no SaintCoinach definition found
         */

        /* offset: 0024 col: 19
         *  name: RequiredQuest
         *  type: 
         */

        /* offset: 002e col: 20
         *  name: Map
         *  type: 
         */

        /* offset: 0030 col: 21
         *  name: Aetherstream{X}
         *  type: 
         */

        /* offset: 0032 col: 22
         *  name: Aetherstream{Y}
         *  type: 
         */

        /* offset: 0035 col: 23
         *  no SaintCoinach definition found
         */



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

        // col: 16 offset: 0010
        public string unknown10;

        // col: 11 offset: 0014
        public uint[] Level;

        // col: 19 offset: 0024
        public uint RequiredQuest;

        // col: 08 offset: 0028
        public ushort PlaceName;

        // col: 09 offset: 002a
        public ushort AethernetName;

        // col: 10 offset: 002c
        public ushort Territory;

        // col: 20 offset: 002e
        public ushort Map;

        // col: 21 offset: 0030
        public short AetherstreamX;

        // col: 22 offset: 0032
        public short AetherstreamY;

        // col: 17 offset: 0034
        public byte AethernetGroup;

        // col: 23 offset: 0035
        public byte unknown35;

        // col: 15 offset: 0036
        private byte packed36;
        public bool IsAetheryte => ( packed36 & 0x1 ) == 0x1;
        public bool packed36_2 => ( packed36 & 0x2 ) == 0x2;


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

            // col: 16 offset: 0010
            unknown10 = parser.ReadOffset< string >( 0x10 );

            // col: 11 offset: 0014
            Level = new uint[4];
            Level[0] = parser.ReadOffset< uint >( 0x14 );
            Level[1] = parser.ReadOffset< uint >( 0x18 );
            Level[2] = parser.ReadOffset< uint >( 0x1c );
            Level[3] = parser.ReadOffset< uint >( 0x20 );

            // col: 19 offset: 0024
            RequiredQuest = parser.ReadOffset< uint >( 0x24 );

            // col: 8 offset: 0028
            PlaceName = parser.ReadOffset< ushort >( 0x28 );

            // col: 9 offset: 002a
            AethernetName = parser.ReadOffset< ushort >( 0x2a );

            // col: 10 offset: 002c
            Territory = parser.ReadOffset< ushort >( 0x2c );

            // col: 20 offset: 002e
            Map = parser.ReadOffset< ushort >( 0x2e );

            // col: 21 offset: 0030
            AetherstreamX = parser.ReadOffset< short >( 0x30 );

            // col: 22 offset: 0032
            AetherstreamY = parser.ReadOffset< short >( 0x32 );

            // col: 17 offset: 0034
            AethernetGroup = parser.ReadOffset< byte >( 0x34 );

            // col: 23 offset: 0035
            unknown35 = parser.ReadOffset< byte >( 0x35 );

            // col: 15 offset: 0036
            packed36 = parser.ReadOffset< byte >( 0x36 );


        }
    }
}