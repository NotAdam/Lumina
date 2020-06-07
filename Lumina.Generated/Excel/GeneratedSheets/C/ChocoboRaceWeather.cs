using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ChocoboRaceWeather", columnHash: 0xfaedad07 )]
    public class ChocoboRaceWeather : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public int WeatherType1;

        // col: 01 offset: 0004
        public int WeatherType2;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            WeatherType1 = parser.ReadOffset< int >( 0x0 );

            // col: 1 offset: 0004
            WeatherType2 = parser.ReadOffset< int >( 0x4 );


        }
    }
}