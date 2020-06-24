using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "IndividualWeather", columnHash: 0x1012bc70 )]
    public class IndividualWeather : IExcelRow
    {
        
        public LazyRow< Weather >[] Weather;
        public byte Unknown5;
        public byte Unknown6;
        public byte Unknown7;
        public byte Unknown8;
        public byte Unknown9;
        public LazyRow< Quest >[] Quest;
        public uint Unknown15;
        public uint Unknown16;
        public uint Unknown17;
        public uint Unknown18;
        public uint Unknown19;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Weather = new LazyRow< Weather >[ 5 ];
            for( var i = 0; i < 5; i++ )
                Weather[ i ] = new LazyRow< Weather >( lumina, parser.ReadColumn< byte >( 0 + i ), language );
            Unknown5 = parser.ReadColumn< byte >( 5 );
            Unknown6 = parser.ReadColumn< byte >( 6 );
            Unknown7 = parser.ReadColumn< byte >( 7 );
            Unknown8 = parser.ReadColumn< byte >( 8 );
            Unknown9 = parser.ReadColumn< byte >( 9 );
            Quest = new LazyRow< Quest >[ 5 ];
            for( var i = 0; i < 5; i++ )
                Quest[ i ] = new LazyRow< Quest >( lumina, parser.ReadColumn< uint >( 10 + i ), language );
            Unknown15 = parser.ReadColumn< uint >( 15 );
            Unknown16 = parser.ReadColumn< uint >( 16 );
            Unknown17 = parser.ReadColumn< uint >( 17 );
            Unknown18 = parser.ReadColumn< uint >( 18 );
            Unknown19 = parser.ReadColumn< uint >( 19 );
        }
    }
}