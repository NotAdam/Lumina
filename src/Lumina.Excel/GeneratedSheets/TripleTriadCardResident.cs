// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "TripleTriadCardResident", columnHash: 0x996e0a5e )]
    public class TripleTriadCardResident : ExcelRow
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
        public ushort Order;
        public byte UIPriority;
        public bool Unknown54;
        public byte AcquisitionType;
        public uint Acquisition;
        public uint Location;
        public LazyRow< Quest > Quest;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Unknown0 = parser.ReadColumn< ushort >( 0 );
            Top = parser.ReadColumn< byte >( 1 );
            Bottom = parser.ReadColumn< byte >( 2 );
            Left = parser.ReadColumn< byte >( 3 );
            Right = parser.ReadColumn< byte >( 4 );
            TripleTriadCardRarity = new LazyRow< TripleTriadCardRarity >( lumina, parser.ReadColumn< byte >( 5 ), language );
            TripleTriadCardType = new LazyRow< TripleTriadCardType >( lumina, parser.ReadColumn< byte >( 6 ), language );
            SaleValue = parser.ReadColumn< ushort >( 7 );
            SortKey = parser.ReadColumn< byte >( 8 );
            Order = parser.ReadColumn< ushort >( 9 );
            UIPriority = parser.ReadColumn< byte >( 10 );
            Unknown54 = parser.ReadColumn< bool >( 11 );
            AcquisitionType = parser.ReadColumn< byte >( 12 );
            Acquisition = parser.ReadColumn< uint >( 13 );
            Location = parser.ReadColumn< uint >( 14 );
            Quest = new LazyRow< Quest >( lumina, parser.ReadColumn< uint >( 15 ), language );
        }
    }
}