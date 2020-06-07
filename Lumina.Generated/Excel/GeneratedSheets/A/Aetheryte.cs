using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Aetheryte", columnHash: 0xcd1e31a4 )]
    public class Aetheryte : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


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
        public bool IsAetheryte;
        public byte packed36;
        public bool packed36_2;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

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
            packed36 = parser.ReadOffset< byte >( 0x36, ExcelColumnDataType.UInt8 );

            IsAetheryte = ( packed36 & 0x1 ) == 0x1;
            packed36_2 = ( packed36 & 0x2 ) == 0x2;


        }
    }
}