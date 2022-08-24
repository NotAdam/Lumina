// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "BaseParam", columnHash: 0x8568afe3 )]
    public partial class BaseParam : ExcelRow
    {
        
        public sbyte PacketIndex { get; set; }
        public SeString Name { get; set; }
        public SeString Description { get; set; }
        public byte OrderPriority { get; set; }
        public ushort oneHWpnPct { get; set; }
        public ushort OHPct { get; set; }
        public ushort HeadPct { get; set; }
        public ushort ChestPct { get; set; }
        public ushort HandsPct { get; set; }
        public ushort WaistPct { get; set; }
        public ushort LegsPct { get; set; }
        public ushort FeetPct { get; set; }
        public ushort EarringPct { get; set; }
        public ushort NecklacePct { get; set; }
        public ushort BraceletPct { get; set; }
        public ushort RingPct { get; set; }
        public ushort twoHWpnPct { get; set; }
        public ushort UnderArmorPct { get; set; }
        public ushort ChestHeadPct { get; set; }
        public ushort ChestHeadLegsFeetPct { get; set; }
        public ushort Unknown20 { get; set; }
        public ushort LegsFeetPct { get; set; }
        public ushort HeadChestHandsLegsFeetPct { get; set; }
        public ushort ChestLegsGlovesPct { get; set; }
        public ushort ChestLegsFeetPct { get; set; }
        public ushort Unknown25 { get; set; }
        public byte[] MeldParam { get; set; }
        public bool Unknown39 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            PacketIndex = parser.ReadColumn< sbyte >( 0 );
            Name = parser.ReadColumn< SeString >( 1 );
            Description = parser.ReadColumn< SeString >( 2 );
            OrderPriority = parser.ReadColumn< byte >( 3 );
            oneHWpnPct = parser.ReadColumn< ushort >( 4 );
            OHPct = parser.ReadColumn< ushort >( 5 );
            HeadPct = parser.ReadColumn< ushort >( 6 );
            ChestPct = parser.ReadColumn< ushort >( 7 );
            HandsPct = parser.ReadColumn< ushort >( 8 );
            WaistPct = parser.ReadColumn< ushort >( 9 );
            LegsPct = parser.ReadColumn< ushort >( 10 );
            FeetPct = parser.ReadColumn< ushort >( 11 );
            EarringPct = parser.ReadColumn< ushort >( 12 );
            NecklacePct = parser.ReadColumn< ushort >( 13 );
            BraceletPct = parser.ReadColumn< ushort >( 14 );
            RingPct = parser.ReadColumn< ushort >( 15 );
            twoHWpnPct = parser.ReadColumn< ushort >( 16 );
            UnderArmorPct = parser.ReadColumn< ushort >( 17 );
            ChestHeadPct = parser.ReadColumn< ushort >( 18 );
            ChestHeadLegsFeetPct = parser.ReadColumn< ushort >( 19 );
            Unknown20 = parser.ReadColumn< ushort >( 20 );
            LegsFeetPct = parser.ReadColumn< ushort >( 21 );
            HeadChestHandsLegsFeetPct = parser.ReadColumn< ushort >( 22 );
            ChestLegsGlovesPct = parser.ReadColumn< ushort >( 23 );
            ChestLegsFeetPct = parser.ReadColumn< ushort >( 24 );
            Unknown25 = parser.ReadColumn< ushort >( 25 );
            MeldParam = new byte[ 13 ];
            for( var i = 0; i < 13; i++ )
                MeldParam[ i ] = parser.ReadColumn< byte >( 26 + i );
            Unknown39 = parser.ReadColumn< bool >( 39 );
        }
    }
}