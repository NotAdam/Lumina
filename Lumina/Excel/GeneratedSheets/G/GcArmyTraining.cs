using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GcArmyTraining", columnHash: 0x274780bb )]
    public class GcArmyTraining : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 04 offset: 0000
        public string Name;

        // col: 05 offset: 0004
        public string Description;

        // col: 03 offset: 0008
        public uint Experience;

        // col: 00 offset: 000c
        public sbyte PhysicalBonus;

        // col: 01 offset: 000d
        public sbyte MentalBonus;

        // col: 02 offset: 000e
        public sbyte TacticalBonus;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 4 offset: 0000
            Name = parser.ReadOffset< string >( 0x0 );

            // col: 5 offset: 0004
            Description = parser.ReadOffset< string >( 0x4 );

            // col: 3 offset: 0008
            Experience = parser.ReadOffset< uint >( 0x8 );

            // col: 0 offset: 000c
            PhysicalBonus = parser.ReadOffset< sbyte >( 0xc );

            // col: 1 offset: 000d
            MentalBonus = parser.ReadOffset< sbyte >( 0xd );

            // col: 2 offset: 000e
            TacticalBonus = parser.ReadOffset< sbyte >( 0xe );


        }
    }
}