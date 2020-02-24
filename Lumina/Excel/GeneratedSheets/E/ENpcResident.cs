namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ENpcResident", columnHash: 0xf74fa88c )]
    public class ENpcResident : IExcelRow
    {
        // column defs from Fri, 28 Jun 2019 17:13:11 GMT

        /* offset: 0000 col: 0
         *  name: Singular
         *  type: 
         */

        /* offset: 000c col: 1
         *  name: Adjective
         *  type: 
         */

        /* offset: 0004 col: 2
         *  name: Plural
         *  type: 
         */

        /* offset: 000d col: 3
         *  name: PossessivePronoun
         *  type: 
         */

        /* offset: 000e col: 4
         *  name: StartsWithVowel
         *  type: 
         */

        /* offset: 000f col: 5
         *  no SaintCoinach definition found
         */

        /* offset: 0010 col: 6
         *  name: Pronoun
         *  type: 
         */

        /* offset: 0011 col: 7
         *  name: Article
         *  type: 
         */

        /* offset: 0008 col: 8
         *  name: Title
         *  type: 
         */

        /* offset: 0014 col: 9
         *  name: Map
         *  type: 
         */

        /* offset: 0015 col: 10
         *  no SaintCoinach definition found
         */



        // col: 00 offset: 0000
        public string Singular;

        // col: 02 offset: 0004
        public string Plural;

        // col: 08 offset: 0008
        public string Title;

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
        public byte Map;

        // col: 10 offset: 0015
        private byte packed15;
        public bool packed15_1 => ( packed15 & 0x1 ) == 0x1;


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

            // col: 8 offset: 0008
            Title = parser.ReadOffset< string >( 0x8 );

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
            Map = parser.ReadOffset< byte >( 0x14 );

            // col: 10 offset: 0015
            packed15 = parser.ReadOffset< byte >( 0x15 );


        }
    }
}