// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "BaseParam", columnHash: 0xedef6dbb )]
    public partial class BaseParam : ExcelRow
    {
        
        public sbyte PacketIndex { get; set; }
        public SeString Name { get; set; }
        public SeString Description { get; set; }
        public byte OrderPriority { get; set; }
        public byte oneHWpnPct { get; set; }
        public byte OHPct { get; set; }
        public byte HeadPct { get; set; }
        public byte ChestPct { get; set; }
        public byte HandsPct { get; set; }
        public byte WaistPct { get; set; }
        public byte LegsPct { get; set; }
        public byte FeetPct { get; set; }
        public byte EarringPct { get; set; }
        public byte NecklacePct { get; set; }
        public byte BraceletPct { get; set; }
        public byte RingPct { get; set; }
        public byte twoHWpnPct { get; set; }
        public byte UnderArmorPct { get; set; }
        public byte ChestHeadPct { get; set; }
        public byte ChestHeadLegsFeetPct { get; set; }
        public byte Unknown20 { get; set; }
        public byte LegsFeetPct { get; set; }
        public byte HeadChestHandsLegsFeetPct { get; set; }
        public byte ChestLegsGlovesPct { get; set; }
        public byte ChestLegsFeetPct { get; set; }
        public byte[] MeldParam { get; set; }
        public bool Unknown38 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            PacketIndex = parser.ReadColumn< sbyte >( 0 );
            Name = parser.ReadColumn< SeString >( 1 );
            Description = parser.ReadColumn< SeString >( 2 );
            OrderPriority = parser.ReadColumn< byte >( 3 );
            oneHWpnPct = parser.ReadColumn< byte >( 4 );
            OHPct = parser.ReadColumn< byte >( 5 );
            HeadPct = parser.ReadColumn< byte >( 6 );
            ChestPct = parser.ReadColumn< byte >( 7 );
            HandsPct = parser.ReadColumn< byte >( 8 );
            WaistPct = parser.ReadColumn< byte >( 9 );
            LegsPct = parser.ReadColumn< byte >( 10 );
            FeetPct = parser.ReadColumn< byte >( 11 );
            EarringPct = parser.ReadColumn< byte >( 12 );
            NecklacePct = parser.ReadColumn< byte >( 13 );
            BraceletPct = parser.ReadColumn< byte >( 14 );
            RingPct = parser.ReadColumn< byte >( 15 );
            twoHWpnPct = parser.ReadColumn< byte >( 16 );
            UnderArmorPct = parser.ReadColumn< byte >( 17 );
            ChestHeadPct = parser.ReadColumn< byte >( 18 );
            ChestHeadLegsFeetPct = parser.ReadColumn< byte >( 19 );
            Unknown20 = parser.ReadColumn< byte >( 20 );
            LegsFeetPct = parser.ReadColumn< byte >( 21 );
            HeadChestHandsLegsFeetPct = parser.ReadColumn< byte >( 22 );
            ChestLegsGlovesPct = parser.ReadColumn< byte >( 23 );
            ChestLegsFeetPct = parser.ReadColumn< byte >( 24 );
            MeldParam = new byte[ 13 ];
            for( var i = 0; i < 13; i++ )
                MeldParam[ i ] = parser.ReadColumn< byte >( 25 + i );
            Unknown38 = parser.ReadColumn< bool >( 38 );
        }
    }
}