using System;

namespace Lumina.Excel
{
    public class SheetAttribute : Attribute
    {
        public readonly string Name;
        public readonly uint? ColumnHash;

        public SheetAttribute( string name )
        {
            Name = name;
        }

        public SheetAttribute( string name, uint columnHash ) : this( name )
        {
            ColumnHash = columnHash;
        }
    }
}