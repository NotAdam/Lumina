// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Status", columnHash: 0x15af357d )]
    public class Status : ExcelRow
    {
        
        public SeString Name { get; set; }
        public SeString Description { get; set; }
        public ushort Icon { get; set; }
        public byte Unknown3 { get; set; }
        public byte MaxStacks { get; set; }
        public byte Unknown5 { get; set; }
        public byte Category { get; set; }
        public LazyRow< StatusHitEffect > HitEffect { get; set; }
        public LazyRow< StatusLoopVFX > VFX { get; set; }
        public bool LockMovement { get; set; }
        public bool Unknown10 { get; set; }
        public bool LockActions { get; set; }
        public bool LockControl { get; set; }
        public bool Transfiguration { get; set; }
        public bool Unknown14 { get; set; }
        public bool CanDispel { get; set; }
        public bool InflictedByActor { get; set; }
        public bool IsPermanent { get; set; }
        public byte PartyListPriority { get; set; }
        public byte Unknown19 { get; set; }
        public bool Unknown20 { get; set; }
        public bool Unknown21 { get; set; }
        public short Unknown22 { get; set; }
        public byte Unknown23 { get; set; }
        public bool Unknown24 { get; set; }
        public ushort Log { get; set; }
        public bool IsFcBuff { get; set; }
        public bool Invisibility { get; set; }
        public byte Unknown28 { get; set; }
        public byte Unknown29 { get; set; }
        public byte Unknown30 { get; set; }
        public bool Unknown31 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Name = parser.ReadColumn< SeString >( 0 );
            Description = parser.ReadColumn< SeString >( 1 );
            Icon = parser.ReadColumn< ushort >( 2 );
            Unknown3 = parser.ReadColumn< byte >( 3 );
            MaxStacks = parser.ReadColumn< byte >( 4 );
            Unknown5 = parser.ReadColumn< byte >( 5 );
            Category = parser.ReadColumn< byte >( 6 );
            HitEffect = new LazyRow< StatusHitEffect >( gameData, parser.ReadColumn< byte >( 7 ), language );
            VFX = new LazyRow< StatusLoopVFX >( gameData, parser.ReadColumn< ushort >( 8 ), language );
            LockMovement = parser.ReadColumn< bool >( 9 );
            Unknown10 = parser.ReadColumn< bool >( 10 );
            LockActions = parser.ReadColumn< bool >( 11 );
            LockControl = parser.ReadColumn< bool >( 12 );
            Transfiguration = parser.ReadColumn< bool >( 13 );
            Unknown14 = parser.ReadColumn< bool >( 14 );
            CanDispel = parser.ReadColumn< bool >( 15 );
            InflictedByActor = parser.ReadColumn< bool >( 16 );
            IsPermanent = parser.ReadColumn< bool >( 17 );
            PartyListPriority = parser.ReadColumn< byte >( 18 );
            Unknown19 = parser.ReadColumn< byte >( 19 );
            Unknown20 = parser.ReadColumn< bool >( 20 );
            Unknown21 = parser.ReadColumn< bool >( 21 );
            Unknown22 = parser.ReadColumn< short >( 22 );
            Unknown23 = parser.ReadColumn< byte >( 23 );
            Unknown24 = parser.ReadColumn< bool >( 24 );
            Log = parser.ReadColumn< ushort >( 25 );
            IsFcBuff = parser.ReadColumn< bool >( 26 );
            Invisibility = parser.ReadColumn< bool >( 27 );
            Unknown28 = parser.ReadColumn< byte >( 28 );
            Unknown29 = parser.ReadColumn< byte >( 29 );
            Unknown30 = parser.ReadColumn< byte >( 30 );
            Unknown31 = parser.ReadColumn< bool >( 31 );
        }
    }
}