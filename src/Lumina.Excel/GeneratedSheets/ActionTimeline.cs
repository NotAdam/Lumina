// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ActionTimeline", columnHash: 0x3ae4a5a0 )]
    public partial class ActionTimeline : ExcelRow
    {
        
        public byte Type { get; set; }
        public byte Priority { get; set; }
        public bool Pause { get; set; }
        public byte Stance { get; set; }
        public byte Slot { get; set; }
        public byte LookAtMode { get; set; }
        public SeString Key { get; set; }
        public byte ActionTimelineIDMode { get; set; }
        public LazyRow< WeaponTimeline > WeaponTimeline { get; set; }
        public byte LoadType { get; set; }
        public byte StartAttach { get; set; }
        public byte ResidentPap { get; set; }
        public bool Resident { get; set; }
        public ushort KillUpper { get; set; }
        public bool IsMotionCanceledByMoving { get; set; }
        public bool Unknown15 { get; set; }
        public byte IsLoop { get; set; }
        public bool Unknown17 { get; set; }
        public bool Unknown18 { get; set; }
        public bool Unknown19 { get; set; }
        public byte Unknown20 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Type = parser.ReadColumn< byte >( 0 );
            Priority = parser.ReadColumn< byte >( 1 );
            Pause = parser.ReadColumn< bool >( 2 );
            Stance = parser.ReadColumn< byte >( 3 );
            Slot = parser.ReadColumn< byte >( 4 );
            LookAtMode = parser.ReadColumn< byte >( 5 );
            Key = parser.ReadColumn< SeString >( 6 );
            ActionTimelineIDMode = parser.ReadColumn< byte >( 7 );
            WeaponTimeline = new LazyRow< WeaponTimeline >( gameData, parser.ReadColumn< byte >( 8 ), language );
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
            Unknown20 = parser.ReadColumn< byte >( 20 );
        }
    }
}