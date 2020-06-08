using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "BaseParam", columnHash: 0xedef6dbb )]
    public class BaseParam : IExcelRow
    {
        
        public sbyte PacketIndex;
        public string Name;
        public string Description;
        public byte OrderPriority;
        public byte oneHWpnPct;
        public byte OHPct;
        public byte HeadPct;
        public byte ChestPct;
        public byte HandsPct;
        public byte WaistPct;
        public byte LegsPct;
        public byte FeetPct;
        public byte EarringPct;
        public byte NecklacePct;
        public byte BraceletPct;
        public byte RingPct;
        public byte twoHWpnPct;
        public byte UnderArmorPct;
        public byte ChestHeadPct;
        public byte ChestHeadLegsFeetPct;
        public byte Unknown20;
        public byte LegsFeetPct;
        public byte HeadChestHandsLegsFeetPct;
        public byte ChestLegsGlovesPct;
        public byte ChestLegsFeetPct;
        public byte[] MeldParam;
        public bool Unknown38;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            PacketIndex = parser.ReadColumn< sbyte >( 0 );
            Name = parser.ReadColumn< string >( 1 );
            Description = parser.ReadColumn< string >( 2 );
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