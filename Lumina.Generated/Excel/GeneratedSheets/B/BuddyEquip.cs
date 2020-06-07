using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "BuddyEquip", columnHash: 0xb429792a )]
    public class BuddyEquip : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public string Singular;

        // col: 02 offset: 0004
        public string Plural;

        // col: 08 offset: 0008
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

        // col: 09 offset: 0014
        public int ModelTop;

        // col: 10 offset: 0018
        public int ModelBody;

        // col: 11 offset: 001c
        public int ModelLegs;

        // col: 13 offset: 0020
        public ushort IconHead;

        // col: 14 offset: 0022
        public ushort IconBody;

        // col: 15 offset: 0024
        public ushort IconLegs;

        // col: 12 offset: 0026
        public byte GrandCompany;

        // col: 16 offset: 0027
        public byte unknown27;


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

            // col: 8 offset: 0008
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

            // col: 9 offset: 0014
            ModelTop = parser.ReadOffset< int >( 0x14 );

            // col: 10 offset: 0018
            ModelBody = parser.ReadOffset< int >( 0x18 );

            // col: 11 offset: 001c
            ModelLegs = parser.ReadOffset< int >( 0x1c );

            // col: 13 offset: 0020
            IconHead = parser.ReadOffset< ushort >( 0x20 );

            // col: 14 offset: 0022
            IconBody = parser.ReadOffset< ushort >( 0x22 );

            // col: 15 offset: 0024
            IconLegs = parser.ReadOffset< ushort >( 0x24 );

            // col: 12 offset: 0026
            GrandCompany = parser.ReadOffset< byte >( 0x26 );

            // col: 16 offset: 0027
            unknown27 = parser.ReadOffset< byte >( 0x27 );


        }
    }
}