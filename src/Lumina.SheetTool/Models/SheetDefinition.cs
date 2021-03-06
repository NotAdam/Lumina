namespace Lumina.SheetTool.Models
{
    public enum SheetDefinitionMode
    {
        Columns,
        Offset
    }
    
    public class SheetDefinition
    {
        /// <summary>
        /// The excel sheet name.
        /// </summary>
        /// <remarks>
        /// Case sensitive.
        /// </remarks>
        public string Name { get; set; }
        
        /// <summary>
        /// The hash of the columns data in the header to validate data integrity.
        /// </summary>
        public uint ColumnHash { get; set; }
        
        public SheetDefinitionMode DefinitionMode { get; set; }
    }
}