using System.Runtime.InteropServices;

namespace Lumina.Data.Structs.Excel
{
    [StructLayout(LayoutKind.Sequential)]
    public struct ExcelLanguage
    {
        public Language Language;
        // no idea wtf this is
    #pragma warning disable 169
        private byte _unknown0;
    #pragma warning restore 169
    }
}