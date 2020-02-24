namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DeepDungeonItem", columnHash: 0x878768c6 )]
    public class DeepDungeonItem : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT

        /* offset: 0018 col: 0
         *  name: Icon
         *  type: 
         */

        /* offset: 0000 col: 1
         *  name: Singular
         *  type: 
         */

        /* offset: 0010 col: 2
         *  name: Adjective
         *  type: 
         */

        /* offset: 0004 col: 3
         *  name: Plural
         *  type: 
         */

        /* offset: 0011 col: 4
         *  name: PossessivePronoun
         *  type: 
         */

        /* offset: 0012 col: 5
         *  name: StartsWithVowel
         *  type: 
         */

        /* offset: 0013 col: 6
         *  no SaintCoinach definition found
         */

        /* offset: 0014 col: 7
         *  name: Pronoun
         *  type: 
         */

        /* offset: 0015 col: 8
         *  name: Article
         *  type: 
         */

        /* offset: 0008 col: 9
         *  name: Name
         *  type: 
         */

        /* offset: 000c col: 10
         *  name: Tooltip
         *  type: 
         */

        /* offset: 001c col: 11
         *  name: Action
         *  type: 
         */



        // col: 01 offset: 0000
        public string Singular;

        // col: 03 offset: 0004
        public string Plural;

        // col: 09 offset: 0008
        public string Name;

        // col: 10 offset: 000c
        public string Tooltip;

        // col: 02 offset: 0010
        public sbyte Adjective;

        // col: 04 offset: 0011
        public sbyte PossessivePronoun;

        // col: 05 offset: 0012
        public sbyte StartsWithVowel;

        // col: 06 offset: 0013
        public sbyte unknown13;

        // col: 07 offset: 0014
        public sbyte Pronoun;

        // col: 08 offset: 0015
        public sbyte Article;

        // col: 00 offset: 0018
        public uint Icon;

        // col: 11 offset: 001c
        public uint Action;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 1 offset: 0000
            Singular = parser.ReadOffset< string >( 0x0 );

            // col: 3 offset: 0004
            Plural = parser.ReadOffset< string >( 0x4 );

            // col: 9 offset: 0008
            Name = parser.ReadOffset< string >( 0x8 );

            // col: 10 offset: 000c
            Tooltip = parser.ReadOffset< string >( 0xc );

            // col: 2 offset: 0010
            Adjective = parser.ReadOffset< sbyte >( 0x10 );

            // col: 4 offset: 0011
            PossessivePronoun = parser.ReadOffset< sbyte >( 0x11 );

            // col: 5 offset: 0012
            StartsWithVowel = parser.ReadOffset< sbyte >( 0x12 );

            // col: 6 offset: 0013
            unknown13 = parser.ReadOffset< sbyte >( 0x13 );

            // col: 7 offset: 0014
            Pronoun = parser.ReadOffset< sbyte >( 0x14 );

            // col: 8 offset: 0015
            Article = parser.ReadOffset< sbyte >( 0x15 );

            // col: 0 offset: 0018
            Icon = parser.ReadOffset< uint >( 0x18 );

            // col: 11 offset: 001c
            Action = parser.ReadOffset< uint >( 0x1c );


        }
    }
}