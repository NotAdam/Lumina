using System.Collections.Generic;
using Newtonsoft.Json;

namespace Lumina.SpaghettiUpdater
{
    public static class SheetDefinition
    {
        public class When
        {
            [JsonProperty( "key" )] public string Key { get; set; }
            [JsonProperty( "value" )] public int Value { get; set; }

            public When Clone()
            {
                return new When { Key = Key, Value = Value };
            }
        }

        public class Link
        {
            [JsonProperty( "when" )] public When When { get; set; }
            [JsonProperty( "project" )] public string Project { get; set; }
            [JsonProperty( "key" )] public string Key { get; set; }
            [JsonProperty( "sheet" )] public string LinkedSheet { get; set; }
            [JsonProperty( "sheets" )] public List< string > Sheets { get; set; }

            public Link Clone()
            {
                var ret = new Link()
                {
                    When = When.Clone(),
                    Project = Project,
                    LinkedSheet = LinkedSheet,
                    Key = Key,
                    Sheets = new List< string >()
                };
                foreach( var sheet in Sheets )
                    ret.Sheets.Add( sheet );
                return ret;
            }
        }

        public class Converter
        {
            [JsonProperty( "type" )] public string Type { get; set; }
            [JsonProperty( "target" )] public string Target { get; set; }
            [JsonProperty( "links" )] public List< Link > Links { get; set; }
            [JsonProperty( "targets" )] public List< string > Targets { get; set; }

            public Converter Clone()
            {
                var ret = new Converter()
                {
                    Type = Type,
                    Target = Target,
                    Links = new List< Link >(),
                    Targets = new List< string >()
                };
                foreach( var link in Links )
                {
                    ret.Links.Add( link.Clone() );
                }

                foreach( var target in Targets )
                {
                    ret.Targets.Add( target );
                }

                return ret;
            }
        }

        public class Member
        {
            [JsonProperty( "name" )] public string Name { get; set; }
            [JsonProperty( "converter" )] public Converter Converter { get; set; }
            [JsonProperty( "type" )] public string Type { get; set; }
            [JsonProperty( "count" )] public int Count { get; set; }
            [JsonProperty( "definition" )] public Definition Definition { get; set; }

            public Member Clone()
            {
                return new Member()
                {
                    Name = Name,
                    Converter = Converter.Clone(),
                    Type = Type,
                    Count = Count,
                    Definition = Definition
                };
            }
        }

        public class Definition
        {
            [JsonProperty( "index" )] public uint Index { get; set; }
            [JsonProperty( "name" )] public string Name { get; set; }
            [JsonProperty( "converter" )] public Converter Converter { get; set; }
            [JsonProperty( "type" )] public string Type { get; set; }
            [JsonProperty( "count" )] public int Count { get; set; }
            [JsonProperty( "definition" )] public Definition DefinitionRef { get; set; }
            [JsonProperty( "members" )] public List< Member > Members { get; set; }

            internal string DefName
            {
                get => Name ?? DefinitionRef.Name;
                set => DefName = value;
            }

            public Definition Clone()
            {
                var ret = new Definition()
                {
                    Name = Name,
                    Converter = Converter,
                    Index = Index,
                    Type = Type,
                    Count = Count,
                    DefinitionRef = DefinitionRef,
                    Members = Members == null ? null : new List< Member >()
                };
                
                if (ret.Members != null)
                    foreach( var member in Members )
                        ret.Members.Add( member.Clone() );
                return ret;
            }
        }

        public class Sheet
        {
            [JsonProperty( "sheet" )] public string SheetName { get; set; }
            [JsonProperty( "defaultColumn" )] public string DefaultColumn { get; set; }
            [JsonProperty( "isGenericReferenceTarget" )] public bool IsGenericReferenceTarget { get; set; }
            [JsonProperty( "definitions" )] public List< Definition > Definitions { get; set; }

            public Sheet Clone()
            {
                var ret = new Sheet()
                {
                    SheetName = SheetName,
                    DefaultColumn = DefaultColumn,
                    IsGenericReferenceTarget = IsGenericReferenceTarget,
                    Definitions = new List< Definition >()
                };
                foreach( var def in Definitions )
                    ret.Definitions.Add( def.Clone() );

                return ret;
            }
        }
    }
}