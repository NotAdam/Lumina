// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Status", columnHash: 0x6a0f00f4 )]
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
        public bool Unknown20;
        public short Unknown21;
        public byte Unknown22;
        public bool Unknown23;
        public ushort Log;
        public bool IsFcBuff;
        public bool Invisibility;
        public byte Unknown27;
        public byte Unknown28;
        public bool Unknown29;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Name = parser.ReadColumn< string >( 0 );
            Description = parser.ReadColumn< string >( 1 );
            Icon = parser.ReadColumn< ushort >( 2 );
            MaxStacks = parser.ReadColumn< byte >( 3 );
            Unknown4 = parser.ReadColumn< byte >( 4 );
            Category = parser.ReadColumn< byte >( 5 );
            HitEffect = new LazyRow< StatusHitEffect >( lumina, parser.ReadColumn< byte >( 6 ), language );
            VFX = new LazyRow< StatusLoopVFX >( lumina, parser.ReadColumn< byte >( 7 ), language );
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