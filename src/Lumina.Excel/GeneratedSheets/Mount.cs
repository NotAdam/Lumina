// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Mount", columnHash: 0x8885ae41 )]
    public partial class Mount : ExcelRow
    {
        
        public SeString Singular { get; set; }
        public sbyte Adjective { get; set; }
        public SeString Plural { get; set; }
        public sbyte PossessivePronoun { get; set; }
        public sbyte StartsWithVowel { get; set; }
        public sbyte Unknown5 { get; set; }
        public sbyte Pronoun { get; set; }
        public sbyte Article { get; set; }
        public LazyRow< ModelChara > ModelChara { get; set; }
        public ushort Unknown9 { get; set; }
        public LazyRow< MountFlyingCondition > FlyingCondition { get; set; }
        public byte Unknown11 { get; set; }
        public byte Unknown12 { get; set; }
        public byte Unknown13 { get; set; }
        public byte IsFlying { get; set; }
        public byte Unknown15 { get; set; }
        public LazyRow< MountCustomize > MountCustomize { get; set; }
        public LazyRow< BGM > RideBGM { get; set; }
        public SeString Unknown18 { get; set; }
        public SeString Unknown19 { get; set; }
        public SeString Unknown20 { get; set; }
        public byte ExitMoveDist { get; set; }
        public byte ExitMoveSpeed { get; set; }
        public bool Unknown23 { get; set; }
        public bool IsEmote { get; set; }
        public int EquipHead { get; set; }
        public int EquipBody { get; set; }
        public int EquipLeg { get; set; }
        public int EquipFoot { get; set; }
        public short Order { get; set; }
        public ushort Icon { get; set; }
        public byte UIPriority { get; set; }
        public byte RadiusRate { get; set; }
        public byte BaseMotionSpeed_Run { get; set; }
        public byte BaseMotionSpeed_Walk { get; set; }
        public byte Unknown35 { get; set; }
        public byte ExtraSeats { get; set; }
        public LazyRow< MountAction > MountAction { get; set; }
        public bool IsAirborne { get; set; }
        public bool ExHotbarEnableConfig { get; set; }
        public bool UseEP { get; set; }
        public bool Unknown41 { get; set; }
        public bool IsImmobile { get; set; }
        public byte Unknown43 { get; set; }
        public byte Unknown44 { get; set; }
        public bool Unknown45 { get; set; }
        public bool Unknown46 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Singular = parser.ReadColumn< SeString >( 0 );
            Adjective = parser.ReadColumn< sbyte >( 1 );
            Plural = parser.ReadColumn< SeString >( 2 );
            PossessivePronoun = parser.ReadColumn< sbyte >( 3 );
            StartsWithVowel = parser.ReadColumn< sbyte >( 4 );
            Unknown5 = parser.ReadColumn< sbyte >( 5 );
            Pronoun = parser.ReadColumn< sbyte >( 6 );
            Article = parser.ReadColumn< sbyte >( 7 );
            ModelChara = new LazyRow< ModelChara >( gameData, parser.ReadColumn< int >( 8 ), language );
            Unknown9 = parser.ReadColumn< ushort >( 9 );
            FlyingCondition = new LazyRow< MountFlyingCondition >( gameData, parser.ReadColumn< byte >( 10 ), language );
            Unknown11 = parser.ReadColumn< byte >( 11 );
            Unknown12 = parser.ReadColumn< byte >( 12 );
            Unknown13 = parser.ReadColumn< byte >( 13 );
            IsFlying = parser.ReadColumn< byte >( 14 );
            Unknown15 = parser.ReadColumn< byte >( 15 );
            MountCustomize = new LazyRow< MountCustomize >( gameData, parser.ReadColumn< byte >( 16 ), language );
            RideBGM = new LazyRow< BGM >( gameData, parser.ReadColumn< ushort >( 17 ), language );
            Unknown18 = parser.ReadColumn< SeString >( 18 );
            Unknown19 = parser.ReadColumn< SeString >( 19 );
            Unknown20 = parser.ReadColumn< SeString >( 20 );
            ExitMoveDist = parser.ReadColumn< byte >( 21 );
            ExitMoveSpeed = parser.ReadColumn< byte >( 22 );
            Unknown23 = parser.ReadColumn< bool >( 23 );
            IsEmote = parser.ReadColumn< bool >( 24 );
            EquipHead = parser.ReadColumn< int >( 25 );
            EquipBody = parser.ReadColumn< int >( 26 );
            EquipLeg = parser.ReadColumn< int >( 27 );
            EquipFoot = parser.ReadColumn< int >( 28 );
            Order = parser.ReadColumn< short >( 29 );
            Icon = parser.ReadColumn< ushort >( 30 );
            UIPriority = parser.ReadColumn< byte >( 31 );
            RadiusRate = parser.ReadColumn< byte >( 32 );
            BaseMotionSpeed_Run = parser.ReadColumn< byte >( 33 );
            BaseMotionSpeed_Walk = parser.ReadColumn< byte >( 34 );
            Unknown35 = parser.ReadColumn< byte >( 35 );
            ExtraSeats = parser.ReadColumn< byte >( 36 );
            MountAction = new LazyRow< MountAction >( gameData, parser.ReadColumn< ushort >( 37 ), language );
            IsAirborne = parser.ReadColumn< bool >( 38 );
            ExHotbarEnableConfig = parser.ReadColumn< bool >( 39 );
            UseEP = parser.ReadColumn< bool >( 40 );
            Unknown41 = parser.ReadColumn< bool >( 41 );
            IsImmobile = parser.ReadColumn< bool >( 42 );
            Unknown43 = parser.ReadColumn< byte >( 43 );
            Unknown44 = parser.ReadColumn< byte >( 44 );
            Unknown45 = parser.ReadColumn< bool >( 45 );
            Unknown46 = parser.ReadColumn< bool >( 46 );
        }
    }
}