using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Status", columnHash: 0xd8ae9831 )]
    public class Status : IExcelRow
    {
        
        public string Name;
        public string Description;
        public ushort Icon;
        public byte MaxStacks;
        public byte Unknown4;
        public byte Category;
        public LazyRow< StatusHitEffect > HitEffect;
        public LazyRow< StatusLoopVFX > VFX;
        public bool LockMovement;
        public bool Unknown9;
        public bool LockActions;
        public bool LockControl;
        public bool Transfiguration;
        public bool Unknown13;
        public bool CanDispel;
        public bool InflictedByActor;
        public bool IsPermanent;
        public byte PartyListPriority;
        public bool Unknown18;
        public bool Unknown19;
        public short Unknown20;
        public byte Unknown21;
        public bool Unknown22;
        public ushort Log;
        public bool IsFcBuff;
        public bool Invisibility;
        public byte Unknown26;
        public byte Unknown27;
        public bool Unknown28;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Name = parser.ReadColumn< string >( 0 );
            Description = parser.ReadColumn< string >( 1 );
            Icon = parser.ReadColumn< ushort >( 2 );
            MaxStacks = parser.ReadColumn< byte >( 3 );
            Unknown4 = parser.ReadColumn< byte >( 4 );
            Category = parser.ReadColumn< byte >( 5 );
            HitEffect = new LazyRow< StatusHitEffect >( lumina, parser.ReadColumn< byte >( 6 ) );
            VFX = new LazyRow< StatusLoopVFX >( lumina, parser.ReadColumn< byte >( 7 ) );
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
            Unknown20 = parser.ReadColumn< short >( 20 );
            Unknown21 = parser.ReadColumn< byte >( 21 );
            Unknown22 = parser.ReadColumn< bool >( 22 );
            Log = parser.ReadColumn< ushort >( 23 );
            IsFcBuff = parser.ReadColumn< bool >( 24 );
            Invisibility = parser.ReadColumn< bool >( 25 );
            Unknown26 = parser.ReadColumn< byte >( 26 );
            Unknown27 = parser.ReadColumn< byte >( 27 );
            Unknown28 = parser.ReadColumn< bool >( 28 );
        }
    }
}