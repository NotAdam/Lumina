// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GcArmyExpedition", columnHash: 0x852cc288 )]
    public class GcArmyExpedition : ExcelRow
    {
        public class UnkData10Obj
        {
            public int RewardItem;
        }
        public class UnkData16Obj
        {
            public byte RewardQuantity;
        }
        public class UnkData22Obj
        {
            public ushort RequiredPhysical;
        }
        public class UnkData28Obj
        {
            public byte PercentPhysicalMet;
        }
        public class UnkData34Obj
        {
            public ushort RequiredMental;
        }
        public class UnkData40Obj
        {
            public byte PercentMentalMet;
        }
        public class UnkData46Obj
        {
            public ushort RequiredTactical;
        }
        public class UnkData52Obj
        {
            public byte PercentTacticalMet;
        }
        public class UnkData58Obj
        {
            public byte PercentAllMet;
        }
        
        public byte RequiredFlag { get; set; }
        public byte UnlockFlag { get; set; }
        public byte RequiredLevel { get; set; }
        public ushort RequiredSeals { get; set; }
        public uint RewardExperience { get; set; }
        public byte PercentBase { get; set; }
        public byte Unknown6 { get; set; }
        public LazyRow< GcArmyExpeditionType > GcArmyExpeditionType { get; set; }
        public SeString Name { get; set; }
        public SeString Description { get; set; }
        public UnkData10Obj[] UnkData10 { get; set; }
        public UnkData16Obj[] UnkData16 { get; set; }
        public UnkData22Obj[] UnkData22 { get; set; }
        public UnkData28Obj[] UnkData28 { get; set; }
        public UnkData34Obj[] UnkData34 { get; set; }
        public UnkData40Obj[] UnkData40 { get; set; }
        public UnkData46Obj[] UnkData46 { get; set; }
        public UnkData52Obj[] UnkData52 { get; set; }
        public UnkData58Obj[] UnkData58 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            RequiredFlag = parser.ReadColumn< byte >( 0 );
            UnlockFlag = parser.ReadColumn< byte >( 1 );
            RequiredLevel = parser.ReadColumn< byte >( 2 );
            RequiredSeals = parser.ReadColumn< ushort >( 3 );
            RewardExperience = parser.ReadColumn< uint >( 4 );
            PercentBase = parser.ReadColumn< byte >( 5 );
            Unknown6 = parser.ReadColumn< byte >( 6 );
            GcArmyExpeditionType = new LazyRow< GcArmyExpeditionType >( gameData, parser.ReadColumn< byte >( 7 ), language );
            Name = parser.ReadColumn< SeString >( 8 );
            Description = parser.ReadColumn< SeString >( 9 );
            UnkData10 = new UnkData10Obj[ 6 ];
            for( var i = 0; i < 6; i++ )
            {
                UnkData10[ i ] = new UnkData10Obj();
                UnkData10[ i ].RewardItem = parser.ReadColumn< int >( 10 + ( i * 1 + 0 ) );
            }
            UnkData16 = new UnkData16Obj[ 6 ];
            for( var i = 0; i < 6; i++ )
            {
                UnkData16[ i ] = new UnkData16Obj();
                UnkData16[ i ].RewardQuantity = parser.ReadColumn< byte >( 16 + ( i * 1 + 0 ) );
            }
            UnkData22 = new UnkData22Obj[ 6 ];
            for( var i = 0; i < 6; i++ )
            {
                UnkData22[ i ] = new UnkData22Obj();
                UnkData22[ i ].RequiredPhysical = parser.ReadColumn< ushort >( 22 + ( i * 1 + 0 ) );
            }
            UnkData28 = new UnkData28Obj[ 6 ];
            for( var i = 0; i < 6; i++ )
            {
                UnkData28[ i ] = new UnkData28Obj();
                UnkData28[ i ].PercentPhysicalMet = parser.ReadColumn< byte >( 28 + ( i * 1 + 0 ) );
            }
            UnkData34 = new UnkData34Obj[ 6 ];
            for( var i = 0; i < 6; i++ )
            {
                UnkData34[ i ] = new UnkData34Obj();
                UnkData34[ i ].RequiredMental = parser.ReadColumn< ushort >( 34 + ( i * 1 + 0 ) );
            }
            UnkData40 = new UnkData40Obj[ 6 ];
            for( var i = 0; i < 6; i++ )
            {
                UnkData40[ i ] = new UnkData40Obj();
                UnkData40[ i ].PercentMentalMet = parser.ReadColumn< byte >( 40 + ( i * 1 + 0 ) );
            }
            UnkData46 = new UnkData46Obj[ 6 ];
            for( var i = 0; i < 6; i++ )
            {
                UnkData46[ i ] = new UnkData46Obj();
                UnkData46[ i ].RequiredTactical = parser.ReadColumn< ushort >( 46 + ( i * 1 + 0 ) );
            }
            UnkData52 = new UnkData52Obj[ 6 ];
            for( var i = 0; i < 6; i++ )
            {
                UnkData52[ i ] = new UnkData52Obj();
                UnkData52[ i ].PercentTacticalMet = parser.ReadColumn< byte >( 52 + ( i * 1 + 0 ) );
            }
            UnkData58 = new UnkData58Obj[ 6 ];
            for( var i = 0; i < 6; i++ )
            {
                UnkData58[ i ] = new UnkData58Obj();
                UnkData58[ i ].PercentAllMet = parser.ReadColumn< byte >( 58 + ( i * 1 + 0 ) );
            }
        }
    }
}