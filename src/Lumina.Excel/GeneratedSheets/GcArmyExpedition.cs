// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GcArmyExpedition", columnHash: 0x852cc288 )]
    public class GcArmyExpedition : ExcelRow
    {
        public struct UnkStruct10Struct
        {
            public int RewardItem;
        }
        public struct UnkStruct16Struct
        {
            public byte RewardQuantity;
        }
        public struct UnkStruct22Struct
        {
            public ushort RequiredPhysical;
        }
        public struct UnkStruct28Struct
        {
            public byte PercentPhysicalMet;
        }
        public struct UnkStruct34Struct
        {
            public ushort RequiredMental;
        }
        public struct UnkStruct40Struct
        {
            public byte PercentMentalMet;
        }
        public struct UnkStruct46Struct
        {
            public ushort RequiredTactical;
        }
        public struct UnkStruct52Struct
        {
            public byte PercentTacticalMet;
        }
        public struct UnkStruct58Struct
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
        public UnkStruct10Struct[] UnkStruct10 { get; set; }
        public UnkStruct16Struct[] UnkStruct16 { get; set; }
        public UnkStruct22Struct[] UnkStruct22 { get; set; }
        public UnkStruct28Struct[] UnkStruct28 { get; set; }
        public UnkStruct34Struct[] UnkStruct34 { get; set; }
        public UnkStruct40Struct[] UnkStruct40 { get; set; }
        public UnkStruct46Struct[] UnkStruct46 { get; set; }
        public UnkStruct52Struct[] UnkStruct52 { get; set; }
        public UnkStruct58Struct[] UnkStruct58 { get; set; }
        
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
            UnkStruct10 = new UnkStruct10Struct[ 6 ];
            for( var i = 0; i < 6; i++ )
            {
                UnkStruct10[ i ] = new UnkStruct10Struct();
                UnkStruct10[ i ].RewardItem = parser.ReadColumn< int >( 10 + ( i * 1 + 0 ) );
            }
            UnkStruct16 = new UnkStruct16Struct[ 6 ];
            for( var i = 0; i < 6; i++ )
            {
                UnkStruct16[ i ] = new UnkStruct16Struct();
                UnkStruct16[ i ].RewardQuantity = parser.ReadColumn< byte >( 16 + ( i * 1 + 0 ) );
            }
            UnkStruct22 = new UnkStruct22Struct[ 6 ];
            for( var i = 0; i < 6; i++ )
            {
                UnkStruct22[ i ] = new UnkStruct22Struct();
                UnkStruct22[ i ].RequiredPhysical = parser.ReadColumn< ushort >( 22 + ( i * 1 + 0 ) );
            }
            UnkStruct28 = new UnkStruct28Struct[ 6 ];
            for( var i = 0; i < 6; i++ )
            {
                UnkStruct28[ i ] = new UnkStruct28Struct();
                UnkStruct28[ i ].PercentPhysicalMet = parser.ReadColumn< byte >( 28 + ( i * 1 + 0 ) );
            }
            UnkStruct34 = new UnkStruct34Struct[ 6 ];
            for( var i = 0; i < 6; i++ )
            {
                UnkStruct34[ i ] = new UnkStruct34Struct();
                UnkStruct34[ i ].RequiredMental = parser.ReadColumn< ushort >( 34 + ( i * 1 + 0 ) );
            }
            UnkStruct40 = new UnkStruct40Struct[ 6 ];
            for( var i = 0; i < 6; i++ )
            {
                UnkStruct40[ i ] = new UnkStruct40Struct();
                UnkStruct40[ i ].PercentMentalMet = parser.ReadColumn< byte >( 40 + ( i * 1 + 0 ) );
            }
            UnkStruct46 = new UnkStruct46Struct[ 6 ];
            for( var i = 0; i < 6; i++ )
            {
                UnkStruct46[ i ] = new UnkStruct46Struct();
                UnkStruct46[ i ].RequiredTactical = parser.ReadColumn< ushort >( 46 + ( i * 1 + 0 ) );
            }
            UnkStruct52 = new UnkStruct52Struct[ 6 ];
            for( var i = 0; i < 6; i++ )
            {
                UnkStruct52[ i ] = new UnkStruct52Struct();
                UnkStruct52[ i ].PercentTacticalMet = parser.ReadColumn< byte >( 52 + ( i * 1 + 0 ) );
            }
            UnkStruct58 = new UnkStruct58Struct[ 6 ];
            for( var i = 0; i < 6; i++ )
            {
                UnkStruct58[ i ] = new UnkStruct58Struct();
                UnkStruct58[ i ].PercentAllMet = parser.ReadColumn< byte >( 58 + ( i * 1 + 0 ) );
            }
        }
    }
}