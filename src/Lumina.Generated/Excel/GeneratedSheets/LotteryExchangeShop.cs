using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "LotteryExchangeShop", columnHash: 0xea26200e )]
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
        public string Unknown49;
        public bool Unknown50;
        
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
            Unknown49 = parser.ReadColumn< string >( 49 );
            Unknown50 = parser.ReadColumn< bool >( 50 );
        }
    }
}