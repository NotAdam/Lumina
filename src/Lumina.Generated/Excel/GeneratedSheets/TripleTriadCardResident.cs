// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "TripleTriadCardResident", columnHash: 0xcce12103 )]
    public class TripleTriadCardResident : IExcelRow
    {
        
        public ushort Unknown0;
        public byte Top;
        public byte Bottom;
        public byte Left;
        public byte Right;
        public LazyRow< TripleTriadCardRarity > TripleTriadCardRarity;
        public LazyRow< TripleTriadCardType > TripleTriadCardType;
        public ushort SaleValue;
        public byte SortKey;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Unknown0 = parser.ReadColumn< ushort >( 0 );
            Top = parser.ReadColumn< byte >( 1 );
            Bottom = parser.ReadColumn< byte >( 2 );
            Left = parser.ReadColumn< byte >( 3 );
            Right = parser.ReadColumn< byte >( 4 );
            TripleTriadCardRarity = new LazyRow< TripleTriadCardRarity >( lumina, parser.ReadColumn< byte >( 5 ), language );
            TripleTriadCardType = new LazyRow< TripleTriadCardType >( lumina, parser.ReadColumn< byte >( 6 ), language );
            SaleValue = parser.ReadColumn< ushort >( 7 );
            SortKey = parser.ReadColumn< byte >( 8 );
        }
    }
}