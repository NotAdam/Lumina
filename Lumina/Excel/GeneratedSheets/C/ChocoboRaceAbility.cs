using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ChocoboRaceAbility", columnHash: 0xc68f9e95 )]
    public class ChocoboRaceAbility : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT


        // col: 00 offset: 0000
        public string Name;

        // col: 01 offset: 0004
        public string Description;

        // col: 02 offset: 0008
        public uint Icon;

        // col: 04 offset: 000c
        public byte Value;

        // col: 03 offset: 000d
        public sbyte ChocoboRaceAbilityType;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Name = parser.ReadOffset< string >( 0x0 );

            // col: 1 offset: 0004
            Description = parser.ReadOffset< string >( 0x4 );

            // col: 2 offset: 0008
            Icon = parser.ReadOffset< uint >( 0x8 );

            // col: 4 offset: 000c
            Value = parser.ReadOffset< byte >( 0xc );

            // col: 3 offset: 000d
            ChocoboRaceAbilityType = parser.ReadOffset< sbyte >( 0xd );


        }
    }
}