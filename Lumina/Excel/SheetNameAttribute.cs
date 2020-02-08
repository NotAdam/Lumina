using System;

namespace Lumina.Excel
{
    public class SheetNameAttribute : Attribute
    {
        public readonly string Name;

        public SheetNameAttribute( string name )
        {
            Name = name;
        }
    }
}