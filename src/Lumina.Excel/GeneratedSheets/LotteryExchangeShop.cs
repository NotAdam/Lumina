// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "LotteryExchangeShop", columnHash: 0xbbf60148 )]
    public class LotteryExchangeShop : IExcelRow
    {
        
        public string Unknown0;
        public LazyRow< Item >[] ItemAccepted;
        public uint[] AmountAccepted;
        public byte Unknown33;
        public byte Unknown34;
        public byte Unknown35;
        public byte Unknown36;
        public byte Unknown37;
        public byte Unknown38;
        public byte Unknown39;
        public byte Unknown40;
        public byte Unknown41;
        public byte Unknown42;
        public byte Unknown43;
        public byte Unknown44;
        public byte Unknown45;
        public byte Unknown46;
        public byte Unknown47;
        public byte Unknown48;
        public byte Unknown49;
        public byte Unknown50;
        public byte Unknown51;
        public byte Unknown52;
        public byte Unknown53;
        public byte Unknown54;
        public byte Unknown55;
        public byte Unknown56;
        public byte Unknown57;
        public byte Unknown58;
        public byte Unknown59;
        public byte Unknown60;
        public byte Unknown61;
        public byte Unknown62;
        public byte Unknown63;
        public byte Unknown64;
        public string Lua;
        public LazyRow< LogMessage >[] LogMessage;
        public uint Unknown68;
        public bool Unknown69;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Unknown0 = parser.ReadColumn< string >( 0 );
            ItemAccepted = new LazyRow< Item >[ 16 ];
            for( var i = 0; i < 16; i++ )
                ItemAccepted[ i ] = new LazyRow< Item >( lumina, parser.ReadColumn< int >( 1 + i ), language );
            AmountAccepted = new uint[ 16 ];
            for( var i = 0; i < 16; i++ )
                AmountAccepted[ i ] = parser.ReadColumn< uint >( 17 + i );
            Unknown33 = parser.ReadColumn< byte >( 33 );
            Unknown34 = parser.ReadColumn< byte >( 34 );
            Unknown35 = parser.ReadColumn< byte >( 35 );
            Unknown36 = parser.ReadColumn< byte >( 36 );
            Unknown37 = parser.ReadColumn< byte >( 37 );
            Unknown38 = parser.ReadColumn< byte >( 38 );
            Unknown39 = parser.ReadColumn< byte >( 39 );
            Unknown40 = parser.ReadColumn< byte >( 40 );
            Unknown41 = parser.ReadColumn< byte >( 41 );
            Unknown42 = parser.ReadColumn< byte >( 42 );
            Unknown43 = parser.ReadColumn< byte >( 43 );
            Unknown44 = parser.ReadColumn< byte >( 44 );
            Unknown45 = parser.ReadColumn< byte >( 45 );
            Unknown46 = parser.ReadColumn< byte >( 46 );
            Unknown47 = parser.ReadColumn< byte >( 47 );
            Unknown48 = parser.ReadColumn< byte >( 48 );
            Unknown49 = parser.ReadColumn< byte >( 49 );
            Unknown50 = parser.ReadColumn< byte >( 50 );
            Unknown51 = parser.ReadColumn< byte >( 51 );
            Unknown52 = parser.ReadColumn< byte >( 52 );
            Unknown53 = parser.ReadColumn< byte >( 53 );
            Unknown54 = parser.ReadColumn< byte >( 54 );
            Unknown55 = parser.ReadColumn< byte >( 55 );
            Unknown56 = parser.ReadColumn< byte >( 56 );
            Unknown57 = parser.ReadColumn< byte >( 57 );
            Unknown58 = parser.ReadColumn< byte >( 58 );
            Unknown59 = parser.ReadColumn< byte >( 59 );
            Unknown60 = parser.ReadColumn< byte >( 60 );
            Unknown61 = parser.ReadColumn< byte >( 61 );
            Unknown62 = parser.ReadColumn< byte >( 62 );
            Unknown63 = parser.ReadColumn< byte >( 63 );
            Unknown64 = parser.ReadColumn< byte >( 64 );
            Lua = parser.ReadColumn< string >( 65 );
            LogMessage = new LazyRow< LogMessage >[ 2 ];
            for( var i = 0; i < 2; i++ )
                LogMessage[ i ] = new LazyRow< LogMessage >( lumina, parser.ReadColumn< uint >( 66 + i ), language );
            Unknown68 = parser.ReadColumn< uint >( 68 );
            Unknown69 = parser.ReadColumn< bool >( 69 );
        }
    }
}