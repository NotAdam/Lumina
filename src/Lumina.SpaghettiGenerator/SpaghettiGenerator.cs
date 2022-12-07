using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Lumina.Data.Structs.Excel;
using Lumina.SpaghettiGenerator.CodeGen;
using Newtonsoft.Json;

namespace Lumina.SpaghettiGenerator
{
    public class SpaghettiGenerator
    {
        public GameData GameData;
        public string _sheetTemplate;

        public SpaghettiGenerator(string path, string tmplPath = null)
        {
            GameData = new GameData( path );
            _sheetTemplate = File.ReadAllText( tmplPath ?? "class.tmpl" );
        }

        public static string Clean( string str )
        {
            if( string.IsNullOrWhiteSpace( str ) )
                return null;

            str = str
                .Replace( "<", "" )
                .Replace( ">", "" )
                .Replace( "{", "" )
                .Replace( "}", "" )
                .Replace( "(", "" )
                .Replace( ")", "" )
                .Replace( "/", "" )
                .Replace( "[", "" )
                .Replace( "]", "" )
                .Replace( " ", "" )
                .Replace( "'", "" )
                .Replace( "-", "" )
                .Replace( "%", "Pct" );

            if( char.IsDigit( str[ 0 ] ) )
            {
                // kill me
                var index = str[ 0 ] - '0';
                var fucking = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

                str = $"{fucking[ index ]}{str.Substring( 1 )}";
            }

            return str;
        }

        public static string ExcelTypeToManaged( ExcelColumnDataType type )
        {
            switch( type )
            {
                case ExcelColumnDataType.String:
                    return "SeString";
                case ExcelColumnDataType.Bool:
                    return "bool";
                case ExcelColumnDataType.Int8:
                    return "sbyte";
                case ExcelColumnDataType.UInt8:
                    return "byte";
                case ExcelColumnDataType.Int16:
                    return "short";
                case ExcelColumnDataType.UInt16:
                    return "ushort";
                case ExcelColumnDataType.Int32:
                    return "int";
                case ExcelColumnDataType.UInt32:
                    return "uint";
                case ExcelColumnDataType.Float32:
                    return "float";
                case ExcelColumnDataType.Int64:
                    return "long";
                case ExcelColumnDataType.UInt64:
                    return "ulong";
                case ExcelColumnDataType.PackedBool0:
                case ExcelColumnDataType.PackedBool1:
                case ExcelColumnDataType.PackedBool2:
                case ExcelColumnDataType.PackedBool3:
                case ExcelColumnDataType.PackedBool4:
                case ExcelColumnDataType.PackedBool5:
                case ExcelColumnDataType.PackedBool6:
                case ExcelColumnDataType.PackedBool7:
                    return "bool";
                default:
                    throw new ArgumentOutOfRangeException( nameof( type ), type, null );
            }
        }

        public static bool DefinitionExists( string name )
        {
            return File.Exists( $"./Definitions/{name}.json" );
        }

        public string ProcessDefinition( string name )
        {
            var path = $"./Definitions/{name}.json";
            var lastModified = File.GetLastWriteTime( path );
            var def = File.ReadAllText( path );
            var tmpl = _sheetTemplate;

            var sheet = GameData.Excel.GetSheetRaw( name );
            if( sheet == null )
            {
                Console.WriteLine( $" - sheet {name} no longer exists!" );
                return null;
            }
            
            tmpl = tmpl.Replace( "%%SHEET_NAME%%", name );
            var hash = sheet.HeaderFile.GetColumnsHash();
            tmpl = tmpl.Replace( "%%COL_HASH%%", $"0x{hash:x8}" );
            

            var cols = sheet.Columns;

            var schema = JsonConvert.DeserializeObject< SheetDefinition >( def );

            var generators = new List< BaseShitGenerator >();

            for( uint i = 0; i < cols.Length; i++ )
            {
                var column = cols[ i ];
                var schemaDef = schema.Definitions.FirstOrDefault( d => d.Index == i );

                var type = column.Type;
                var clrType = ExcelTypeToManaged( type );

                if( schemaDef == null )
                {
                    var generator = new PrimitiveGenerator( clrType, $"Unknown{i}", i );
                    
                    generators.Add( generator );

                    continue;
                }
                
                schemaDef.Name = Clean( schemaDef.Name );
                var schemaType = schemaDef.Type;
                
                // single field
                if( schemaType == null )
                {
                    if( schemaDef.ConverterType == "link" && DefinitionExists( schemaDef.ConverterTarget ) )
                    {
                        var target = schemaDef.ConverterTarget;
                        
                        generators.Add( new LazyRowGenerator( target, schemaDef.Name, i, cols ) );
                    }
                    // todo: this is fucking ass, maybe we can fake a variant though? lol
                    // else if( schemaDef.ConverterType == "complexlink" )
                    // {
                    //     fieldGenerators.Add( new PrimitiveGenerator( clrType, schemaDef.Name, i ) );
                    // }
                    else
                    {
                        // no link/unsupported
                        generators.Add( new PrimitiveGenerator( clrType, schemaDef.Name, i ) );
                    }
                }
                // repeats
                else if( schemaType == "repeat" )
                {
                    // unfuck shit stupid groups with one member which are actually just arrays
                    if( schemaDef.Definition?.Type == "group" && schemaDef.Definition.Members.Count == 1 )
                    {
                        schemaDef.Definition.Type = "shitgroup";
                        schemaDef.Name = Clean( schemaDef.Definition.Members.First().Name );
                    }
                    
                    // todo: groups need their own handling here but it's kind of shit, probably should do this differently
                    if( schemaDef.Definition?.Type == "group" )
                    {
                        var memberCount = schemaDef.Definition.Members.Count;

                        string className;
                        string fieldName;
                        if( schemaDef.Definition.GroupName != null )
                        {
                            className = $"{schemaDef.Definition.GroupName}Obj";
                            fieldName = schemaDef.Definition.GroupName;
                        }
                        else
                        {
                            className = $"{name}UnkData{i}Obj";
                            fieldName = $"UnkData{i}";
                        }

                        // todo: add pluralisation to field name? lol
                        generators.Add( 
                            new GroupStructGenerator( 
                                className,
                                fieldName, 
                                i,
                                schemaDef.Definition.Members,
                                schemaDef.Count,
                                cols 
                            )
                        );
                        
                        i += ( schemaDef.Count * (uint)memberCount ) - 1;
                    }
                    else
                    {
                        if( schemaDef.ConverterType == "link" && DefinitionExists( schemaDef.ConverterTarget ) )
                        {
                            var target = schemaDef.ConverterTarget;
                            generators.Add( new LazyRowRepeatGenerator( target, schemaDef.Name, i, schemaDef.Count, cols ) );
                        }
                        // todo: this is fucked and i question my sanity if i ever want to actually support this fucking garbage
                        // else if( schemaDef.ConverterType == "complexlink" )
                        // {
                        //     
                        // }
                        else
                        {
                            if( string.IsNullOrEmpty( schemaDef.Name ) )
                            {
                                schemaDef.Name = $"Unknown{i}";
                            }
                            generators.Add( new PrimitiveRepeatGenerator( clrType, schemaDef.Name, i, schemaDef.Count ) );
                        }
                        
                        i += schemaDef.Count - 1;
                    }
                }
            }
            
            var fieldsSb = new StringBuilder();
            var readsSb = new StringBuilder();
            var structsSb = new StringBuilder();
            
            // run the generators
            foreach( var generator in generators )
            {
                generator.WriteFields( fieldsSb );
                // fieldsSb.AppendLine();
                generator.WriteReaders( readsSb );
                // readsSb.AppendLine();
                generator.WriteStructs( structsSb );
            }

            // fix indent the big brain way
            Func< StringBuilder, int, string > fixIndent = ( sb, level ) =>
            {
                var indent = "";
                for( int i = 0; i < level * 4; i++ )
                {
                    indent += " ";
                }

                return indent + sb.ToString().Replace( "\n", $"\n{indent}");
            };

            tmpl = tmpl.Replace( "%%STRUCT_DEFS%%", fixIndent( structsSb, 2 ) );
            tmpl = tmpl.Replace( "%%DATA_MEMBERS%%", fixIndent( fieldsSb, 2 ) );
            tmpl = tmpl.Replace( "%%DATA_READERS%%", fixIndent( readsSb, 3 ).TrimEnd() );

            return tmpl;
        }
    }
}