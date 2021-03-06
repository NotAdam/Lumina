namespace Lumina.SheetTool.Models
{
    public enum DefinitionType
    {
        None,
        Enum,
        Array
    }
    
    public class ColumnDefinition
    {
        public uint Id { get; set; }
        
        public DefinitionType Type { get; set; }
        
        public uint? Length { get; set; }
        
        public string References { get; set; }
    }
}