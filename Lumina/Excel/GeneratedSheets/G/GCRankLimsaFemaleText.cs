namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GCRankLimsaFemaleText", columnHash: 0xd573cba6 )]
    public class GCRankLimsaFemaleText : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT

        /* offset: 0000 col: 0
         *  name: Singular
         *  type: 
         */

        /* offset: 0010 col: 1
         *  name: Adjective
         *  type: 
         */

        /* offset: 0004 col: 2
         *  name: Plural
         *  type: 
         */

        /* offset: 0011 col: 3
         *  name: PossessivePronoun
         *  type: 
         */

        /* offset: 0012 col: 4
         *  name: StartsWithVowel
         *  type: 
         */

        /* offset: 0013 col: 5
         *  no SaintCoinach definition found
         */

        /* offset: 0014 col: 6
         *  name: Pronoun
         *  type: 
         */

        /* offset: 0015 col: 7
         *  name: Article
         *  type: 
         */

        /* offset: 0008 col: 8
         *  name: Name{Rank}
         *  type: 
         */

        /* offset: 000c col: 9
         *  no SaintCoinach definition found
         */



        // col: 00 offset: 0000
        public string Singular;

        // col: 02 offset: 0004
        public string Plural;

        // col: 08 offset: 0008
        public string NameRank;

        // col: 09 offset: 000c
        public string unknownc;

        // col: 01 offset: 0010
        public sbyte Adjective;

        // col: 03 offset: 0011
        public sbyte PossessivePronoun;

        // col: 04 offset: 0012
        public sbyte StartsWithVowel;

        // col: 05 offset: 0013
        public sbyte unknown13;

        // col: 06 offset: 0014
        public sbyte Pronoun;

        // col: 07 offset: 0015
        public sbyte Article;


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
            NameRank = parser.ReadOffset< string >( 0x8 );

            // col: 9 offset: 000c
            unknownc = parser.ReadOffset< string >( 0xc );

            // col: 1 offset: 0010
            Adjective = parser.ReadOffset< sbyte >( 0x10 );

            // col: 3 offset: 0011
            PossessivePronoun = parser.ReadOffset< sbyte >( 0x11 );

            // col: 4 offset: 0012
            StartsWithVowel = parser.ReadOffset< sbyte >( 0x12 );

            // col: 5 offset: 0013
            unknown13 = parser.ReadOffset< sbyte >( 0x13 );

            // col: 6 offset: 0014
            Pronoun = parser.ReadOffset< sbyte >( 0x14 );

            // col: 7 offset: 0015
            Article = parser.ReadOffset< sbyte >( 0x15 );


        }
    }
}