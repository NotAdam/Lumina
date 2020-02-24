using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ChocoboRace", columnHash: 0xde74b4c4 )]
    public class ChocoboRace : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT


        // col: 00 offset: 0000
        public byte ChocoboRaceRank;

        // col: 01 offset: 0001
        public byte ChocoboRaceTerritory;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            ChocoboRaceRank = parser.ReadOffset< byte >( 0x0 );

            // col: 1 offset: 0001
            ChocoboRaceTerritory = parser.ReadOffset< byte >( 0x1 );


        }
    }
}