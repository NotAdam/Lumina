// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "LotteryExchangeShop", columnHash: 0xfd7b4ce5 )]
    public partial class LotteryExchangeShop : ExcelRow
    {
        
        public SeString Unknown0 { get; set; }
        public LazyRow< Item >[] ItemAccepted { get; set; }
        public uint[] AmountAccepted { get; set; }
        public byte Unknown65 { get; set; }
        public byte Unknown66 { get; set; }
        public byte Unknown67 { get; set; }
        public byte Unknown68 { get; set; }
        public byte Unknown69 { get; set; }
        public byte Unknown70 { get; set; }
        public byte Unknown71 { get; set; }
        public byte Unknown72 { get; set; }
        public byte Unknown73 { get; set; }
        public byte Unknown74 { get; set; }
        public byte Unknown75 { get; set; }
        public byte Unknown76 { get; set; }
        public byte Unknown77 { get; set; }
        public byte Unknown78 { get; set; }
        public byte Unknown79 { get; set; }
        public byte Unknown80 { get; set; }
        public byte Unknown81 { get; set; }
        public byte Unknown82 { get; set; }
        public byte Unknown83 { get; set; }
        public byte Unknown84 { get; set; }
        public byte Unknown85 { get; set; }
        public byte Unknown86 { get; set; }
        public byte Unknown87 { get; set; }
        public byte Unknown88 { get; set; }
        public byte Unknown89 { get; set; }
        public byte Unknown90 { get; set; }
        public byte Unknown91 { get; set; }
        public byte Unknown92 { get; set; }
        public byte Unknown93 { get; set; }
        public byte Unknown94 { get; set; }
        public byte Unknown95 { get; set; }
        public byte Unknown96 { get; set; }
        public byte Unknown97 { get; set; }
        public byte Unknown98 { get; set; }
        public byte Unknown99 { get; set; }
        public byte Unknown100 { get; set; }
        public byte Unknown101 { get; set; }
        public byte Unknown102 { get; set; }
        public byte Unknown103 { get; set; }
        public byte Unknown104 { get; set; }
        public byte Unknown105 { get; set; }
        public byte Unknown106 { get; set; }
        public byte Unknown107 { get; set; }
        public byte Unknown108 { get; set; }
        public byte Unknown109 { get; set; }
        public byte Unknown110 { get; set; }
        public byte Unknown111 { get; set; }
        public byte Unknown112 { get; set; }
        public byte Unknown113 { get; set; }
        public byte Unknown114 { get; set; }
        public byte Unknown115 { get; set; }
        public byte Unknown116 { get; set; }
        public byte Unknown117 { get; set; }
        public byte Unknown118 { get; set; }
        public byte Unknown119 { get; set; }
        public byte Unknown120 { get; set; }
        public byte Unknown121 { get; set; }
        public byte Unknown122 { get; set; }
        public byte Unknown123 { get; set; }
        public byte Unknown124 { get; set; }
        public byte Unknown125 { get; set; }
        public byte Unknown126 { get; set; }
        public byte Unknown127 { get; set; }
        public byte Unknown128 { get; set; }
        public SeString Lua { get; set; }
        public LazyRow< LogMessage >[] LogMessage { get; set; }
        public bool Unknown133 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< SeString >( 0 );
            ItemAccepted = new LazyRow< Item >[ 32 ];
            for( var i = 0; i < 32; i++ )
                ItemAccepted[ i ] = new LazyRow< Item >( gameData, parser.ReadColumn< int >( 1 + i ), language );
            AmountAccepted = new uint[ 32 ];
            for( var i = 0; i < 32; i++ )
                AmountAccepted[ i ] = parser.ReadColumn< uint >( 33 + i );
            Unknown65 = parser.ReadColumn< byte >( 65 );
            Unknown66 = parser.ReadColumn< byte >( 66 );
            Unknown67 = parser.ReadColumn< byte >( 67 );
            Unknown68 = parser.ReadColumn< byte >( 68 );
            Unknown69 = parser.ReadColumn< byte >( 69 );
            Unknown70 = parser.ReadColumn< byte >( 70 );
            Unknown71 = parser.ReadColumn< byte >( 71 );
            Unknown72 = parser.ReadColumn< byte >( 72 );
            Unknown73 = parser.ReadColumn< byte >( 73 );
            Unknown74 = parser.ReadColumn< byte >( 74 );
            Unknown75 = parser.ReadColumn< byte >( 75 );
            Unknown76 = parser.ReadColumn< byte >( 76 );
            Unknown77 = parser.ReadColumn< byte >( 77 );
            Unknown78 = parser.ReadColumn< byte >( 78 );
            Unknown79 = parser.ReadColumn< byte >( 79 );
            Unknown80 = parser.ReadColumn< byte >( 80 );
            Unknown81 = parser.ReadColumn< byte >( 81 );
            Unknown82 = parser.ReadColumn< byte >( 82 );
            Unknown83 = parser.ReadColumn< byte >( 83 );
            Unknown84 = parser.ReadColumn< byte >( 84 );
            Unknown85 = parser.ReadColumn< byte >( 85 );
            Unknown86 = parser.ReadColumn< byte >( 86 );
            Unknown87 = parser.ReadColumn< byte >( 87 );
            Unknown88 = parser.ReadColumn< byte >( 88 );
            Unknown89 = parser.ReadColumn< byte >( 89 );
            Unknown90 = parser.ReadColumn< byte >( 90 );
            Unknown91 = parser.ReadColumn< byte >( 91 );
            Unknown92 = parser.ReadColumn< byte >( 92 );
            Unknown93 = parser.ReadColumn< byte >( 93 );
            Unknown94 = parser.ReadColumn< byte >( 94 );
            Unknown95 = parser.ReadColumn< byte >( 95 );
            Unknown96 = parser.ReadColumn< byte >( 96 );
            Unknown97 = parser.ReadColumn< byte >( 97 );
            Unknown98 = parser.ReadColumn< byte >( 98 );
            Unknown99 = parser.ReadColumn< byte >( 99 );
            Unknown100 = parser.ReadColumn< byte >( 100 );
            Unknown101 = parser.ReadColumn< byte >( 101 );
            Unknown102 = parser.ReadColumn< byte >( 102 );
            Unknown103 = parser.ReadColumn< byte >( 103 );
            Unknown104 = parser.ReadColumn< byte >( 104 );
            Unknown105 = parser.ReadColumn< byte >( 105 );
            Unknown106 = parser.ReadColumn< byte >( 106 );
            Unknown107 = parser.ReadColumn< byte >( 107 );
            Unknown108 = parser.ReadColumn< byte >( 108 );
            Unknown109 = parser.ReadColumn< byte >( 109 );
            Unknown110 = parser.ReadColumn< byte >( 110 );
            Unknown111 = parser.ReadColumn< byte >( 111 );
            Unknown112 = parser.ReadColumn< byte >( 112 );
            Unknown113 = parser.ReadColumn< byte >( 113 );
            Unknown114 = parser.ReadColumn< byte >( 114 );
            Unknown115 = parser.ReadColumn< byte >( 115 );
            Unknown116 = parser.ReadColumn< byte >( 116 );
            Unknown117 = parser.ReadColumn< byte >( 117 );
            Unknown118 = parser.ReadColumn< byte >( 118 );
            Unknown119 = parser.ReadColumn< byte >( 119 );
            Unknown120 = parser.ReadColumn< byte >( 120 );
            Unknown121 = parser.ReadColumn< byte >( 121 );
            Unknown122 = parser.ReadColumn< byte >( 122 );
            Unknown123 = parser.ReadColumn< byte >( 123 );
            Unknown124 = parser.ReadColumn< byte >( 124 );
            Unknown125 = parser.ReadColumn< byte >( 125 );
            Unknown126 = parser.ReadColumn< byte >( 126 );
            Unknown127 = parser.ReadColumn< byte >( 127 );
            Unknown128 = parser.ReadColumn< byte >( 128 );
            Lua = parser.ReadColumn< SeString >( 129 );
            LogMessage = new LazyRow< LogMessage >[ 3 ];
            for( var i = 0; i < 3; i++ )
                LogMessage[ i ] = new LazyRow< LogMessage >( gameData, parser.ReadColumn< uint >( 130 + i ), language );
            Unknown133 = parser.ReadColumn< bool >( 133 );
        }
    }
}