using System;
using System.Buffers.Binary;
using System.Runtime.InteropServices;

namespace Lumina.Excel.Generated
{
    [SheetName("ActionTimeline")]
    public class ActionTimeline : IExcelRow
    {
        public string Name;
        public byte Type;
        public byte Priority;
        public byte Stance;
        public byte Slot;
        public byte LookAtMode;
        public byte ActionTimelineEIDMode;
        public byte WeaponTimeline;
        public byte LoadType;
        public byte StartAttach;
        public bool Pause;
        public bool ResidentPap;
        public bool Resident;
        public bool KillUpper;
        public bool IsMotionCanceledByMoving;
        public bool IsLoop;

        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;
            
            Name = parser.ReadOffset< string >( 0x0 );
            Type = parser.ReadOffset< byte >( 0x6 );
            Priority = parser.ReadOffset< byte >( 0x7 );
            Stance = parser.ReadOffset< byte >( 0x8 );
            Slot = parser.ReadOffset< byte >( 0x9 );
            LookAtMode = parser.ReadOffset< byte >( 0xA );
            ActionTimelineEIDMode = parser.ReadOffset< byte >( 0xB );
            WeaponTimeline = parser.ReadOffset< byte >( 0xC );
            LoadType = parser.ReadOffset< byte >( 0xD );
            StartAttach = parser.ReadOffset< byte >( 0xE );

            Pause = parser.ReadOffset< bool >( 0x11, 0x4 );
            ResidentPap = parser.ReadOffset< bool >( 0x11, 0x8 );
            Resident = parser.ReadOffset< bool >( 0x11, 0x10 );
            KillUpper = parser.ReadOffset< bool >( 0x11, 0x20 );
            IsMotionCanceledByMoving = parser.ReadOffset< bool >( 0x11, 0x40 );
            IsLoop = parser.ReadOffset< bool >( 0x11, 0x80 );
        }
    }
}