// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "TripleTriadCardResident", columnHash: 0x996e0a5e )]
    public partial class TripleTriadCardResident : ExcelRow
    {
        
        public ushort Unknown0 { get; set; }
        public byte Top { get; set; }
        public byte Bottom { get; set; }
        public byte Left { get; set; }
        public byte Right { get; set; }
        public LazyRow< TripleTriadCardRarity > TripleTriadCardRarity { get; set; }
        public LazyRow< TripleTriadCardType > TripleTriadCardType { get; set; }
        public ushort SaleValue { get; set; }
        public byte SortKey { get; set; }
        public ushort Order { get; set; }
        public byte UIPriority { get; set; }
        public bool Unknown11 { get; set; }
        public byte AcquisitionType { get; set; }
        public uint Acquisition { get; set; }
        public uint Location { get; set; }
        public LazyRow< Quest > Quest { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< ushort >( 0 );
            Top = parser.ReadColumn< byte >( 1 );
            Bottom = parser.ReadColumn< byte >( 2 );
            Left = parser.ReadColumn< byte >( 3 );
            Right = parser.ReadColumn< byte >( 4 );
            TripleTriadCardRarity = new LazyRow< TripleTriadCardRarity >( gameData, parser.ReadColumn< byte >( 5 ), language );
            TripleTriadCardType = new LazyRow< TripleTriadCardType >( gameData, parser.ReadColumn< byte >( 6 ), language );
            SaleValue = parser.ReadColumn< ushort >( 7 );
            SortKey = parser.ReadColumn< byte >( 8 );
            Order = parser.ReadColumn< ushort >( 9 );
            UIPriority = parser.ReadColumn< byte >( 10 );
            Unknown11 = parser.ReadColumn< bool >( 11 );
            AcquisitionType = parser.ReadColumn< byte >( 12 );
            Acquisition = parser.ReadColumn< uint >( 13 );
            Location = parser.ReadColumn< uint >( 14 );
            Quest = new LazyRow< Quest >( gameData, parser.ReadColumn< uint >( 15 ), language );
        }
    }
}