using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Mount", columnHash: 0x3b2b9eb0 )]
    public class Mount : IExcelRow
    {
        
        public string Singular;
        public sbyte Adjective;
        public string Plural;
        public sbyte PossessivePronoun;
        public sbyte StartsWithVowel;
        public sbyte Unknown5;
        public sbyte Pronoun;
        public sbyte Article;
        public LazyRow< ModelChara > ModelChara;
        public ushort Unknown9;
        public LazyRow< MountFlyingCondition > FlyingCondition;
        public byte Unknown11;
        public byte Unknown12;
        public byte Unknown13;
        public byte IsFlying;
        public byte Unknown15;
        public LazyRow< MountCustomize > MountCustomize;
        public LazyRow< BGM > RideBGM;
        public string Unknown18;
        public string Unknown19;
        public string Unknown20;
        public byte ExitMoveDist;
        public byte ExitMoveSpeed;
        public bool Unknown23;
        public bool IsEmote;
        public int EquipHead;
        public int EquipBody;
        public int EquipLeg;
        public int EquipFoot;
        public short Order;
        public ushort Icon;
        public byte UIPriority;
        public byte RadiusRate;
        public byte BaseMotionSpeed_Run;
        public byte BaseMotionSpeed_Walk;
        public byte Unknown35;
        public byte ExtraSeats;
        public LazyRow< MountAction > MountAction;
        public bool IsAirborne;
        public bool ExHotbarEnableConfig;
        public bool UseEP;
        public bool Unknown41;
        public bool IsImmobile;
        public byte Unknown43;
        public byte Unknown44;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Singular = parser.ReadColumn< string >( 0 );
            Adjective = parser.ReadColumn< sbyte >( 1 );
            Plural = parser.ReadColumn< string >( 2 );
            PossessivePronoun = parser.ReadColumn< sbyte >( 3 );
            StartsWithVowel = parser.ReadColumn< sbyte >( 4 );
            Unknown5 = parser.ReadColumn< sbyte >( 5 );
            Pronoun = parser.ReadColumn< sbyte >( 6 );
            Article = parser.ReadColumn< sbyte >( 7 );
            ModelChara = new LazyRow< ModelChara >( lumina, parser.ReadColumn< int >( 8 ) );
            Unknown9 = parser.ReadColumn< ushort >( 9 );
            FlyingCondition = new LazyRow< MountFlyingCondition >( lumina, parser.ReadColumn< byte >( 10 ) );
            Unknown11 = parser.ReadColumn< byte >( 11 );
            Unknown12 = parser.ReadColumn< byte >( 12 );
            Unknown13 = parser.ReadColumn< byte >( 13 );
            IsFlying = parser.ReadColumn< byte >( 14 );
            Unknown15 = parser.ReadColumn< byte >( 15 );
            MountCustomize = new LazyRow< MountCustomize >( lumina, parser.ReadColumn< byte >( 16 ) );
            RideBGM = new LazyRow< BGM >( lumina, parser.ReadColumn< ushort >( 17 ) );
            Unknown18 = parser.ReadColumn< string >( 18 );
            Unknown19 = parser.ReadColumn< string >( 19 );
            Unknown20 = parser.ReadColumn< string >( 20 );
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
            MountAction = new LazyRow< MountAction >( lumina, parser.ReadColumn< ushort >( 37 ) );
            IsAirborne = parser.ReadColumn< bool >( 38 );
            ExHotbarEnableConfig = parser.ReadColumn< bool >( 39 );
            UseEP = parser.ReadColumn< bool >( 40 );
            Unknown41 = parser.ReadColumn< bool >( 41 );
            IsImmobile = parser.ReadColumn< bool >( 42 );
            Unknown43 = parser.ReadColumn< byte >( 43 );
            Unknown44 = parser.ReadColumn< byte >( 44 );
        }
    }
}