using System.Collections.Generic;
using Newtonsoft.Json;

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
       
       public string Type { get; set; }
       
       public string GroupName { get; set; }
       
       public Converter Converter { get; set; }
       
       public List< RootDefinition > Members { get; set; }
    }
    
    public class RootDefinition
    {
        [JsonProperty("Name")]
        public string DefName { get; set; }
        public uint Index { get; set; }
        public string Type { get; set; }
        public uint Count { get; set; }
        
        public Definition Definition { get; set; }
        
        public Converter Converter { get; set; }

        // totally fucking retarded, thanks SaintCoinach, very cool
        internal string Name
        {
            get
            {
                return DefName ?? Definition.Name;
            }

            set
            {
                // this'll always take priority over the other retarded field
                DefName = value;
            }
        } 

        // more retarded sc fixes because fuck this fucked shitty schema
        internal string ConverterType => Converter?.Type ?? Definition?.Converter?.Type;
        internal string ConverterTarget => Converter?.Target ?? Definition?.Converter?.Target;
    }
    
    public class SheetDefinition
    {
        public string Sheet { get; set; }
        public string DefaultColumn { get; set; }
        
        public List< RootDefinition > Definitions { get; set; }
    }
}