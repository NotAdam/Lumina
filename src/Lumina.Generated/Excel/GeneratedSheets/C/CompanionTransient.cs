using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CompanionTransient", columnHash: 0xea0b06cf )]
    public class CompanionTransient : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


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
        public bool HasAreaAttack;
        public byte packed18;
        public bool StrengthGate;
        public bool StrengthEye;
        public bool StrengthShield;
        public bool StrengthArcana;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

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
            packed18 = parser.ReadOffset< byte >( 0x18, ExcelColumnDataType.UInt8 );

            HasAreaAttack = ( packed18 & 0x1 ) == 0x1;
            StrengthGate = ( packed18 & 0x2 ) == 0x2;
            StrengthEye = ( packed18 & 0x4 ) == 0x4;
            StrengthShield = ( packed18 & 0x8 ) == 0x8;
            StrengthArcana = ( packed18 & 0x10 ) == 0x10;


        }
    }
}