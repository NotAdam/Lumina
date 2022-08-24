using System;
using System.Runtime.InteropServices;

namespace Lumina.Data.Structs.Excel
{
    [StructLayout( LayoutKind.Sequential )]
    public struct ExcelDataHeader
    {
        public byte[] Magic;
        public UInt16 Version;
        private UInt16 U1;
        public UInt32 IndexSize;
        private UInt16[] U2;

        public static ExcelDataHeader Read( LuminaBinaryReader br )
        {
            return new ExcelDataHeader
            {
                Magic = br.ReadBytes( 4 ),
                Version = br.ReadUInt16(),
                U1 = br.ReadUInt16(),
                IndexSize = br.ReadUInt32(),
                U2 = br.ReadUInt16Array( 10 )
            };
        }
    }
}