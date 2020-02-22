using System;

namespace Lumina.Excel
{
    public class ExcelSheetAttribute : Attribute
    {
        public readonly string Name;

        public ExcelSheetAttribute( string name )
        {
            Name = name;
        }
    }
}