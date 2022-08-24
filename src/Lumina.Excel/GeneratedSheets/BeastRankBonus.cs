// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "BeastRankBonus", columnHash: 0x4d6cbdc3 )]
    public partial class BeastRankBonus : ExcelRow
    {
        
        public ushort Neutral { get; set; }
        public ushort Recognized { get; set; }
        public ushort Friendly { get; set; }
        public ushort Trusted { get; set; }
        public ushort Respected { get; set; }
        public ushort Honored { get; set; }
        public ushort Sworn { get; set; }
        public ushort AlliedBloodsworn { get; set; }
        public LazyRow< Item > Item { get; set; }
        public byte[] ItemQuantity { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Neutral = parser.ReadColumn< ushort >( 0 );
            Recognized = parser.ReadColumn< ushort >( 1 );
            Friendly = parser.ReadColumn< ushort >( 2 );
            Trusted = parser.ReadColumn< ushort >( 3 );
            Respected = parser.ReadColumn< ushort >( 4 );
            Honored = parser.ReadColumn< ushort >( 5 );
            Sworn = parser.ReadColumn< ushort >( 6 );
            AlliedBloodsworn = parser.ReadColumn< ushort >( 7 );
            Item = new LazyRow< Item >( gameData, parser.ReadColumn< uint >( 8 ), language );
            ItemQuantity = new byte[ 8 ];
            for( var i = 0; i < 8; i++ )
                ItemQuantity[ i ] = parser.ReadColumn< byte >( 9 + i );
        }
    }
}