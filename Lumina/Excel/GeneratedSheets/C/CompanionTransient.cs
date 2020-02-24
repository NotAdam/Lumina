namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CompanionTransient", columnHash: 0xea0b06cf )]
    public class CompanionTransient : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT

        /* offset: 0000 col: 0
         *  name: Description
         *  type: 
         */

        /* offset: 0004 col: 1
         *  name: Description{Enhanced}
         *  type: 
         */

        /* offset: 0008 col: 2
         *  name: Tooltip
         *  type: 
         */

        /* offset: 000c col: 3
         *  name: SpecialAction{Name}
         *  type: 
         */

        /* offset: 0010 col: 4
         *  name: SpecialAction{Description}
         *  type: 
         */

        /* offset: 0014 col: 5
         *  name: Attack
         *  type: 
         */

        /* offset: 0015 col: 6
         *  name: Defense
         *  type: 
         */

        /* offset: 0016 col: 7
         *  name: Speed
         *  type: 
         */

        /* offset: 0018 col: 8
         *  name: HasAreaAttack
         *  type: 
         */

        /* offset: 0018 col: 9
         *  name: Strength{Gate}
         *  type: 
         */

        /* offset: 0018 col: 10
         *  name: Strength{Eye}
         *  type: 
         */

        /* offset: 0018 col: 11
         *  name: Strength{Shield}
         *  type: 
         */

        /* offset: 0018 col: 12
         *  name: Strength{Arcana}
         *  type: 
         */

        /* offset: 0017 col: 13
         *  name: MinionSkillType
         *  type: 
         */



        // col: 00 offset: 0000
        public string Description;

        // col: 01 offset: 0004
        public string DescriptionEnhanced;

        // col: 02 offset: 0008
        public string Tooltip;

        // col: 03 offset: 000c
        public string SpecialActionName;

        // col: 04 offset: 0010
        public string SpecialActionDescription;

        // col: 05 offset: 0014
        public byte Attack;

        // col: 06 offset: 0015
        public byte Defense;

        // col: 07 offset: 0016
        public byte Speed;

        // col: 13 offset: 0017
        public byte MinionSkillType;

        // col: 08 offset: 0018
        private byte packed18;
        public bool HasAreaAttack => ( packed18 & 0x1 ) == 0x1;
        public bool StrengthGate => ( packed18 & 0x2 ) == 0x2;
        public bool StrengthEye => ( packed18 & 0x4 ) == 0x4;
        public bool StrengthShield => ( packed18 & 0x8 ) == 0x8;
        public bool StrengthArcana => ( packed18 & 0x10 ) == 0x10;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Description = parser.ReadOffset< string >( 0x0 );

            // col: 1 offset: 0004
            DescriptionEnhanced = parser.ReadOffset< string >( 0x4 );

            // col: 2 offset: 0008
            Tooltip = parser.ReadOffset< string >( 0x8 );

            // col: 3 offset: 000c
            SpecialActionName = parser.ReadOffset< string >( 0xc );

            // col: 4 offset: 0010
            SpecialActionDescription = parser.ReadOffset< string >( 0x10 );

            // col: 5 offset: 0014
            Attack = parser.ReadOffset< byte >( 0x14 );

            // col: 6 offset: 0015
            Defense = parser.ReadOffset< byte >( 0x15 );

            // col: 7 offset: 0016
            Speed = parser.ReadOffset< byte >( 0x16 );

            // col: 13 offset: 0017
            MinionSkillType = parser.ReadOffset< byte >( 0x17 );

            // col: 8 offset: 0018
            packed18 = parser.ReadOffset< byte >( 0x18 );


        }
    }
}