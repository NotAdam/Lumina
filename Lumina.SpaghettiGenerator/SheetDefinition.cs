using System.Collections.Generic;

namespace Lumina.SpaghettiGenerator
{
    public class Converter
    {
        public string Type { get; set; }
        public string Target { get; set; }
    }

    public class Definition
    {
       public string Name { get; set; } 
    }
    
    public class RootDefinition
    {
        public string Name { get; set; }
        public int Index { get; set; }
        public string Type { get; set; }
        public int Count { get; set; }
        
        public Definition Definition { get; set; }

        // totally fucking retarded, thanks SaintCoinach, very cool
        public string RealName => Name ?? Definition.Name;
    }
    
    public class SheetDefinition
    {
        public string Sheet { get; set; }
        public string DefaultColumn { get; set; }
        
        public List< RootDefinition > Definitions { get; set; }
    }
}