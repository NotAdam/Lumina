using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ChocoboRaceTerritory", columnHash: 0x39e8d543 )]
    public class ChocoboRaceTerritory : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 01 offset: 0000
        public int Icon;

        // col: 00 offset: 0004
        public ushort Name;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 1 offset: 0000
            Icon = parser.ReadOffset< int >( 0x0 );

            // col: 0 offset: 0004
            Name = parser.ReadOffset< ushort >( 0x4 );


        }
    }
}