using System;

namespace Lumina.Excel
{
    public class SheetAttribute : Attribute
    {
        /// <summary>
        /// The sheet name
        /// </summary>
        public readonly string Name;
        
        /// <summary>
        /// A column hash - used to warn when a sheet structure has changed
        /// </summary>
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