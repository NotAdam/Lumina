using System;
using System.Buffers.Binary;
using System.Runtime.InteropServices;

namespace Lumina.Excel.Generated
{
    public class ActionTimeline : IExcelRow
    {
        string Name;
        ushort u4;
        byte Type;
        byte Priority;
        byte Stance;
        byte Slot;
        byte LookAtMode;
        byte ActionTimelineEIDMode;
        byte WeaponTimeline;
        byte LoadType;
        byte StartAttach;
        byte unkF;
        byte flag;

        bool Pause => ( flag & 0x4 ) == 0x4;
        bool ResidentPap => ( flag & 0x8 ) == 0x8;
        bool Resident => ( flag & 0x10 ) == 0x10;
        bool KillUpper => ( flag & 0x20 ) == 0x20;
        bool IsMotionCanceledByMoving => ( flag & 0x40 ) == 0x40;
        bool IsLoop => ( flag & 0x80 ) == 0x80;

        public void PopulateData( RowParser parser )
        {
            Name = parser.ReadOffset< string >( 0x0 );
        }
    }
}