using System;
using System.Buffers.Binary;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace Lumina.Data.Structs
{
    [SuppressMessage( "ReSharper", "InconsistentNaming" )]
    public enum PlatformId : byte
    {
        Win32,
        PS3,
        PS4,
        PS5,
        Lys // Xbox
    }
    
    [StructLayout( LayoutKind.Sequential )]
    public struct SqPackHeader
    {
        public byte[] magic;
        public PlatformId platformId;
        public byte[] __unknown;
        public UInt32 size;
        public UInt32 version;
        public UInt32 type;

        public static SqPackHeader Read( LuminaBinaryReader br )
        {
            var header = new SqPackHeader();
            header.magic = br.ReadBytes( 8 );
            header.platformId = (PlatformId)br.ReadByte();
            header.__unknown = br.ReadBytes( 3 );

            br.PlatformId = header.platformId;
            br.IsLittleEndian = header.platformId != PlatformId.PS3;

            header.size = br.ReadUInt32();
            header.version = br.ReadUInt32();
            header.type = br.ReadUInt32();

            return header;
        }
    }
}