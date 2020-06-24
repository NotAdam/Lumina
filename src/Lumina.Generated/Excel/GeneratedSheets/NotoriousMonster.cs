using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "NotoriousMonster", columnHash: 0x307c9206 )]
    public class NotoriousMonster : IExcelRow
    {
        
        public LazyRow< BNpcBase > BNpcBase;
        public byte Rank;
        public LazyRow< BNpcName > BNpcName;
        public ushort Unknown3;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            BNpcBase = new LazyRow< BNpcBase >( lumina, parser.ReadColumn< int >( 0 ), language );
            Rank = parser.ReadColumn< byte >( 1 );
            BNpcName = new LazyRow< BNpcName >( lumina, parser.ReadColumn< uint >( 2 ), language );
            Unknown3 = parser.ReadColumn< ushort >( 3 );
        }
    }
}