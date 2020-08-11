// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "IndividualWeather", columnHash: 0x28885f67 )]
    public class IndividualWeather : IExcelRow
    {
        
        public LazyRow< Weather >[] Weather;
        public byte Unknown6;
        public byte Unknown7;
        public byte Unknown8;
        public byte Unknown9;
        public byte Unknown10;
        public byte Unknown11;
        public byte AddedIn530;
        public byte AddedIn531;
        public uint Unknown14;
        public LazyRow< Quest >[] Quest;
        public uint Unknown21;
        public uint Unknown22;
        public uint Unknown23;
        public uint Unknown24;
        public uint Unknown25;
        public uint Unknown26;
        public uint Unknown27;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Weather = new LazyRow< Weather >[ 6 ];
            for( var i = 0; i < 6; i++ )
                Weather[ i ] = new LazyRow< Weather >( lumina, parser.ReadColumn< byte >( 0 + i ), language );
            Unknown6 = parser.ReadColumn< byte >( 6 );
            Unknown7 = parser.ReadColumn< byte >( 7 );
            Unknown8 = parser.ReadColumn< byte >( 8 );
            Unknown9 = parser.ReadColumn< byte >( 9 );
            Unknown10 = parser.ReadColumn< byte >( 10 );
            Unknown11 = parser.ReadColumn< byte >( 11 );
            AddedIn530 = parser.ReadColumn< byte >( 12 );
            AddedIn531 = parser.ReadColumn< byte >( 13 );
            Unknown14 = parser.ReadColumn< uint >( 14 );
            Quest = new LazyRow< Quest >[ 6 ];
            for( var i = 0; i < 6; i++ )
                Quest[ i ] = new LazyRow< Quest >( lumina, parser.ReadColumn< uint >( 15 + i ), language );
            Unknown21 = parser.ReadColumn< uint >( 21 );
            Unknown22 = parser.ReadColumn< uint >( 22 );
            Unknown23 = parser.ReadColumn< uint >( 23 );
            Unknown24 = parser.ReadColumn< uint >( 24 );
            Unknown25 = parser.ReadColumn< uint >( 25 );
            Unknown26 = parser.ReadColumn< uint >( 26 );
            Unknown27 = parser.ReadColumn< uint >( 27 );
        }
    }
}