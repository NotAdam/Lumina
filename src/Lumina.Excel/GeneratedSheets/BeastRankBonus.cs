// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "BeastRankBonus", columnHash: 0x4d6cbdc3 )]
    public class BeastRankBonus : IExcelRow
    {
        
        public ushort Neutral;
        public ushort Recognized;
        public ushort Friendly;
        public ushort Trusted;
        public ushort Respected;
        public ushort Honored;
        public ushort Sworn;
        public ushort AlliedBloodsworn;
        public LazyRow< Item > Item;
        public byte[] ItemQuantity;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Neutral = parser.ReadColumn< ushort >( 0 );
            Recognized = parser.ReadColumn< ushort >( 1 );
            Friendly = parser.ReadColumn< ushort >( 2 );
            Trusted = parser.ReadColumn< ushort >( 3 );
            Respected = parser.ReadColumn< ushort >( 4 );
            Honored = parser.ReadColumn< ushort >( 5 );
            Sworn = parser.ReadColumn< ushort >( 6 );
            AlliedBloodsworn = parser.ReadColumn< ushort >( 7 );
            Item = new LazyRow< Item >( lumina, parser.ReadColumn< uint >( 8 ), language );
            ItemQuantity = new byte[ 8 ];
            for( var i = 0; i < 8; i++ )
                ItemQuantity[ i ] = parser.ReadColumn< byte >( 9 + i );
        }
    }
}