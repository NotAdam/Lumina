using System;
using System.Buffers.Binary;
using System.Runtime.InteropServices;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.Sheets
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

        private byte _Packed11;

        public bool Pause => ( _Packed11 & 0x1 ) == 0x1;
        public bool ResidentPap => ( _Packed11 & 0x2 ) == 0x2;
        public bool Resident => ( _Packed11 & 0x4 ) == 0x4;
        public bool KillUpper => ( _Packed11 & 0x8 ) == 0x8;
        public bool IsMotionCanceledByMoving => ( _Packed11 & 0x10 ) == 0x10;
        public bool IsLoop => ( _Packed11 & 0x20 ) == 0x20;

        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
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

            _Packed11 = parser.ReadOffset< byte >( 0x11, ExcelColumnDataType.UInt8 );
        }
    }
}