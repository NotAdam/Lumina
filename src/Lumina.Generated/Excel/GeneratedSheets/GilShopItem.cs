using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GilShopItem", columnHash: 0x2f7317fe )]
    public class GilShopItem : IExcelRow
    {
        
        public LazyRow< Item > Item;
        public bool Unknown1;
        public int Unknown2;
        public int[] RowRequired;
        public byte Unknown6;
        public ushort StateRequired;
        public ushort Patch;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Item = new LazyRow< Item >( lumina, parser.ReadColumn< int >( 0 ) );
            Unknown1 = parser.ReadColumn< bool >( 1 );
            Unknown2 = parser.ReadColumn< int >( 2 );
            RowRequired = new int[ 3 ];
            for( var i = 0; i < 3; i++ )
                RowRequired[ i ] = parser.ReadColumn< int >( 3 + i );
            Unknown6 = parser.ReadColumn< byte >( 6 );
            StateRequired = parser.ReadColumn< ushort >( 7 );
            Patch = parser.ReadColumn< ushort >( 8 );
        }
    }
}