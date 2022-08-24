// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GcArmyExpedition", columnHash: 0x852cc288 )]
    public partial class GcArmyExpedition : ExcelRow
    {
        
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
        public int[] RewardItem { get; set; }
        public byte[] RewardQuantity { get; set; }
        public ushort[] RequiredPhysical { get; set; }
        public byte[] PercentPhysicalMet { get; set; }
        public ushort[] RequiredMental { get; set; }
        public byte[] PercentMentalMet { get; set; }
        public ushort[] RequiredTactical { get; set; }
        public byte[] PercentTacticalMet { get; set; }
        public byte[] PercentAllMet { get; set; }
        
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
            RewardItem = new int[ 6 ];
            for( var i = 0; i < 6; i++ )
                RewardItem[ i ] = parser.ReadColumn< int >( 10 + i );
            RewardQuantity = new byte[ 6 ];
            for( var i = 0; i < 6; i++ )
                RewardQuantity[ i ] = parser.ReadColumn< byte >( 16 + i );
            RequiredPhysical = new ushort[ 6 ];
            for( var i = 0; i < 6; i++ )
                RequiredPhysical[ i ] = parser.ReadColumn< ushort >( 22 + i );
            PercentPhysicalMet = new byte[ 6 ];
            for( var i = 0; i < 6; i++ )
                PercentPhysicalMet[ i ] = parser.ReadColumn< byte >( 28 + i );
            RequiredMental = new ushort[ 6 ];
            for( var i = 0; i < 6; i++ )
                RequiredMental[ i ] = parser.ReadColumn< ushort >( 34 + i );
            PercentMentalMet = new byte[ 6 ];
            for( var i = 0; i < 6; i++ )
                PercentMentalMet[ i ] = parser.ReadColumn< byte >( 40 + i );
            RequiredTactical = new ushort[ 6 ];
            for( var i = 0; i < 6; i++ )
                RequiredTactical[ i ] = parser.ReadColumn< ushort >( 46 + i );
            PercentTacticalMet = new byte[ 6 ];
            for( var i = 0; i < 6; i++ )
                PercentTacticalMet[ i ] = parser.ReadColumn< byte >( 52 + i );
            PercentAllMet = new byte[ 6 ];
            for( var i = 0; i < 6; i++ )
                PercentAllMet[ i ] = parser.ReadColumn< byte >( 58 + i );
        }
    }
}