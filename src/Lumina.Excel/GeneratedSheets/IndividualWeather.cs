// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "IndividualWeather", columnHash: 0x4532afe5 )]
    public partial class IndividualWeather : ExcelRow
    {
        
        public LazyRow< Weather >[] Weather { get; set; }
        public byte Unknown6 { get; set; }
        public byte Unknown7 { get; set; }
        public byte Unknown8 { get; set; }
        public byte Unknown9 { get; set; }
        public byte Unknown10 { get; set; }
        public byte Unknown11 { get; set; }
        public byte Unknown12 { get; set; }
        public byte Unknown13 { get; set; }
        public uint Unknown14 { get; set; }
        public LazyRow< Quest >[] Quest { get; set; }
        public uint Unknown21 { get; set; }
        public uint Unknown22 { get; set; }
        public uint Unknown23 { get; set; }
        public uint Unknown24 { get; set; }
        public uint Unknown25 { get; set; }
        public uint Unknown26 { get; set; }
        public uint Unknown27 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Weather = new LazyRow< Weather >[ 6 ];
            for( var i = 0; i < 6; i++ )
                Weather[ i ] = new LazyRow< Weather >( gameData, parser.ReadColumn< byte >( 0 + i ), language );
            Unknown6 = parser.ReadColumn< byte >( 6 );
            Unknown7 = parser.ReadColumn< byte >( 7 );
            Unknown8 = parser.ReadColumn< byte >( 8 );
            Unknown9 = parser.ReadColumn< byte >( 9 );
            Unknown10 = parser.ReadColumn< byte >( 10 );
            Unknown11 = parser.ReadColumn< byte >( 11 );
            Unknown12 = parser.ReadColumn< byte >( 12 );
            Unknown13 = parser.ReadColumn< byte >( 13 );
            Unknown14 = parser.ReadColumn< uint >( 14 );
            Quest = new LazyRow< Quest >[ 6 ];
            for( var i = 0; i < 6; i++ )
                Quest[ i ] = new LazyRow< Quest >( gameData, parser.ReadColumn< uint >( 15 + i ), language );
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