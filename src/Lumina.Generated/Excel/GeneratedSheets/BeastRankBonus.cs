using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "BeastRankBonus", columnHash: 0x4d6cbdc3 )]
    public class BeastRankBonus : IExcelRow
    {
        
        public ushort Unknown0;
        public ushort Unknown1;
        public ushort Unknown2;
        public ushort Unknown3;
        public ushort Unknown4;
        public ushort Unknown5;
        public ushort Unknown6;
        public ushort Unknown7;
        public LazyRow< Item > Item;
        public byte[] ItemQuantity;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Unknown0 = parser.ReadColumn< ushort >( 0 );
            Unknown1 = parser.ReadColumn< ushort >( 1 );
            Unknown2 = parser.ReadColumn< ushort >( 2 );
            Unknown3 = parser.ReadColumn< ushort >( 3 );
            Unknown4 = parser.ReadColumn< ushort >( 4 );
            Unknown5 = parser.ReadColumn< ushort >( 5 );
            Unknown6 = parser.ReadColumn< ushort >( 6 );
            Unknown7 = parser.ReadColumn< ushort >( 7 );
            Item = new LazyRow< Item >( lumina, parser.ReadColumn< uint >( 8 ) );
            for( var i = 0; i < 8; i++ )
                ItemQuantity[ i ] = parser.ReadColumn< byte >( 9 + i );
        }
    }
}