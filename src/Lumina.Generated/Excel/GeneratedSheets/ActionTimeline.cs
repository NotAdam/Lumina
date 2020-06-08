using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ActionTimeline", columnHash: 0x7402d920 )]
    public class ActionTimeline : IExcelRow
    {
        
        public byte Type;
        public byte Priority;
        public bool Pause;
        public byte Stance;
        public byte Slot;
        public byte LookAtMode;
        public string Key;
        public byte ActionTimelineIDMode;
        public LazyRow< WeaponTimeline > WeaponTimeline;
        public byte LoadType;
        public byte StartAttach;
        public byte ResidentPap;
        public bool Resident;
        public ushort KillUpper;
        public bool IsMotionCanceledByMoving;
        public bool Unknown15;
        public byte IsLoop;
        public bool Unknown17;
        public bool Unknown18;
        public bool Unknown19;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Type = parser.ReadColumn< byte >( 0 );
            Priority = parser.ReadColumn< byte >( 1 );
            Pause = parser.ReadColumn< bool >( 2 );
            Stance = parser.ReadColumn< byte >( 3 );
            Slot = parser.ReadColumn< byte >( 4 );
            LookAtMode = parser.ReadColumn< byte >( 5 );
            Key = parser.ReadColumn< string >( 6 );
            ActionTimelineIDMode = parser.ReadColumn< byte >( 7 );
            WeaponTimeline = new LazyRow< WeaponTimeline >( lumina, parser.ReadColumn< byte >( 8 ) );
            LoadType = parser.ReadColumn< byte >( 9 );
            StartAttach = parser.ReadColumn< byte >( 10 );
            ResidentPap = parser.ReadColumn< byte >( 11 );
            Resident = parser.ReadColumn< bool >( 12 );
            KillUpper = parser.ReadColumn< ushort >( 13 );
            IsMotionCanceledByMoving = parser.ReadColumn< bool >( 14 );
            Unknown15 = parser.ReadColumn< bool >( 15 );
            IsLoop = parser.ReadColumn< byte >( 16 );
            Unknown17 = parser.ReadColumn< bool >( 17 );
            Unknown18 = parser.ReadColumn< bool >( 18 );
            Unknown19 = parser.ReadColumn< bool >( 19 );
        }
    }
}