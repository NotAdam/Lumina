// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Status", columnHash: 0xec4473bc )]
    public class Status : ExcelRow
    {
        
        public SeString Name { get; set; }
        public SeString Description { get; set; }
        public ushort Icon { get; set; }
        public byte MaxStacks { get; set; }
        public byte Unknown4 { get; set; }
        public byte Category { get; set; }
        public LazyRow< StatusHitEffect > HitEffect { get; set; }
        public LazyRow< StatusLoopVFX > VFX { get; set; }
        public bool LockMovement { get; set; }
        public bool Unknown9 { get; set; }
        public bool LockActions { get; set; }
        public bool LockControl { get; set; }
        public bool Transfiguration { get; set; }
        public bool Unknown13 { get; set; }
        public bool CanDispel { get; set; }
        public bool InflictedByActor { get; set; }
        public bool IsPermanent { get; set; }
        public byte PartyListPriority { get; set; }
        public bool Unknown18 { get; set; }
        public bool Unknown19 { get; set; }
        public bool Unknown20 { get; set; }
        public short Unknown21 { get; set; }
        public byte Unknown22 { get; set; }
        public bool Unknown23 { get; set; }
        public ushort Log { get; set; }
        public bool IsFcBuff { get; set; }
        public bool Invisibility { get; set; }
        public byte Unknown27 { get; set; }
        public byte Unknown28 { get; set; }
        public bool Unknown29 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Name = parser.ReadColumn< SeString >( 0 );
            Description = parser.ReadColumn< SeString >( 1 );
            Icon = parser.ReadColumn< ushort >( 2 );
            MaxStacks = parser.ReadColumn< byte >( 3 );
            Unknown4 = parser.ReadColumn< byte >( 4 );
            Category = parser.ReadColumn< byte >( 5 );
            HitEffect = new LazyRow< StatusHitEffect >( gameData, parser.ReadColumn< byte >( 6 ), language );
            VFX = new LazyRow< StatusLoopVFX >( gameData, parser.ReadColumn< ushort >( 7 ), language );
            LockMovement = parser.ReadColumn< bool >( 8 );
            Unknown9 = parser.ReadColumn< bool >( 9 );
            LockActions = parser.ReadColumn< bool >( 10 );
            LockControl = parser.ReadColumn< bool >( 11 );
            Transfiguration = parser.ReadColumn< bool >( 12 );
            Unknown13 = parser.ReadColumn< bool >( 13 );
            CanDispel = parser.ReadColumn< bool >( 14 );
            InflictedByActor = parser.ReadColumn< bool >( 15 );
            IsPermanent = parser.ReadColumn< bool >( 16 );
            PartyListPriority = parser.ReadColumn< byte >( 17 );
            Unknown18 = parser.ReadColumn< bool >( 18 );
            Unknown19 = parser.ReadColumn< bool >( 19 );
            Unknown20 = parser.ReadColumn< bool >( 20 );
            Unknown21 = parser.ReadColumn< short >( 21 );
            Unknown22 = parser.ReadColumn< byte >( 22 );
            Unknown23 = parser.ReadColumn< bool >( 23 );
            Log = parser.ReadColumn< ushort >( 24 );
            IsFcBuff = parser.ReadColumn< bool >( 25 );
            Invisibility = parser.ReadColumn< bool >( 26 );
            Unknown27 = parser.ReadColumn< byte >( 27 );
            Unknown28 = parser.ReadColumn< byte >( 28 );
            Unknown29 = parser.ReadColumn< bool >( 29 );
        }
    }
}