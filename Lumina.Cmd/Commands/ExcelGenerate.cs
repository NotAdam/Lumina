using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using CliFx;
using CliFx.Attributes;
using Lumina.Data.Files.Excel;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;
using Newtonsoft.Json;

namespace Lumina.Cmd.Commands
{
    [Command( "excelgenerate",
        Description = "Generates excel objects from schema files." )]
    public class ExcelGenerate : ICommand
    {
        private class Definition
        {
            public string Name { get; set; }
        }

        private class RootDefinition
        {
            public string Name { get; set; }
            public int Index { get; set; }
            public string Type { get; set; }
            public int Count { get; set; }

            public Definition Definition { get; set; }

            // totally fucking retarded, thanks SaintCoinach, very cool
            public string RealName => Name ?? Definition.Name;
        }

        private class SheetDefinition
        {
            public string Sheet { get; set; }
            public string DefaultColumn { get; set; }

            public List< RootDefinition > Definitions { get; set; }
        }

        class DummyExcelSheet : IExcelRow
        {
            public int RowId { get; set; }
            public int SubRowId { get; set; }

            public void PopulateData( RowParser parser, Lumina lumina )
            {
            }
        }

        private class OutputDefinition
        {
            public int Index { get; set; }

            public string Name { get; set; }

            public int ArrayLength { get; set; } = 0;

            public ExcelColumnDataType Type { get; set; }
        }

        [CommandOption( "schema", 's', Description = "Path to the folder with excel schema definitions", IsRequired = true )]
        public string SchemaPath { get; set; }

        [CommandOption( "dataPath", 'p',
            Description = "Path to the client sqpack folder",
            IsRequired = true,
            EnvironmentVariableName = "LUMINA_CMD_CLIENT_PATH" )]
        public string DataPath { get; set; }

        private Lumina _lumina;
        private static string _sheetTemplate;

        public ValueTask ExecuteAsync( IConsole console )
        {
            _lumina = new Lumina( DataPath );
            _sheetTemplate = File.ReadAllText( "Misc/class.tmpl" );

            foreach( var file in Directory.EnumerateFiles( SchemaPath, "*.json" ) )
            {
                var name = Path.GetFileNameWithoutExtension( file );
                Console.WriteLine( $"doing sheet: {name}" );

                var code = ProcessSheet( name );
                if( code == null )
                {
                    continue;
                }
                
                var path = $"./output/{name[ 0 ]}/{name}.cs";
                var dir = Path.GetDirectoryName( path );
                Directory.CreateDirectory( dir );

                File.WriteAllText( path, code );
            }

            return default;
        }

        public string ProcessSheet( string name )
        {
            var path = Path.Combine( SchemaPath, $"{name}.json" );
            var lastModified = File.GetLastWriteTime( path );
            var def = File.ReadAllText( path );

            var schema = JsonConvert.DeserializeObject< SheetDefinition >( def );
            var sheet = _lumina.Excel.GetSheet< DummyExcelSheet >( name );
            if( sheet == null )
            {
                Console.WriteLine( $"sheet {name} no longer exists!".Error() );
                return null;
            }

            var cols = sheet.Columns;
            var output = new List< OutputDefinition >();


            for( var i = 0; i < cols.Length; i++ )
            {
                var col = cols[ i ];
                var schemaDef = schema.Definitions.FirstOrDefault( d => d.Index == i );
                if( schemaDef == null )
                {
                    output.Add( new OutputDefinition
                    {
                        Index = i,
                        Name = $"unknown{i}",
                        ArrayLength = 0,
                        Type = col.Type
                    } );

                    // Console.WriteLine( $"col: index: {i} name: unknown{i}" );

                    continue;
                }

                var colDef = new OutputDefinition
                {
                    Index = i,
                    Name = Clean( schemaDef.RealName ),
                    Type = col.Type,
                    ArrayLength = 0
                };

                if( schemaDef.Type == "repeat" )
                {
                    colDef.ArrayLength = schemaDef.Count;

                    // -1 because of the loop increment
                    i += colDef.ArrayLength - 1;
                }

                // Console.WriteLine( $"col: index: {colDef.Index} name: {colDef.Name}" );

                output.Add( colDef );
            }

            var indent = "        ";

            var sheetOutput = _sheetTemplate;
            sheetOutput = sheetOutput.Replace( "%%SHEET_NAME%%", name );
            var hash = sheet.HeaderFile.GetColumnsHash();
            sheetOutput = sheetOutput.Replace( "%%COL_HASH%%", $"0x{hash:x8}" );
            
            var sb = new StringBuilder();
            sb.Append( indent );
            sb.AppendLine( $"// column defs from {lastModified:R}" );
            sb.AppendLine();

            foreach( var d in output )
            {
                sb.Append( indent );
                sb.AppendLine( BuildDataField( d.Name, d.Type, d.ArrayLength ) );
                sb.AppendLine();
            }

            sheetOutput = sheetOutput.Replace( "%%DATA_MEMBERS%%", sb.ToString() );
            sb.Clear();

            indent = "            ";
            // write data readers
            foreach( var d in output )
            {
                // write regular read
                if( d.ArrayLength == 0 )
                {
                    sb.Append( indent );
                    sb.AppendLine( $"{d.Name} = parser.ReadColumn< {ExcelTypeToManaged( d.Type )} >( {d.Index} );" );
                    sb.AppendLine();

                    continue;
                }
                
                // write arrays
                sb.Append( indent );
                sb.AppendLine( $"{d.Name} = new {ExcelTypeToManaged( d.Type )}[ {d.ArrayLength} ];" );

                for( int i = 0; i < d.ArrayLength; i++ )
                {
                    sb.Append( indent );
                    sb.AppendLine( $"{d.Name}[ {i} ] = parser.ReadColumn< {ExcelTypeToManaged( d.Type )} >( {d.Index + i} );" );
                }

                sb.AppendLine();
            }
            
            sheetOutput = sheetOutput.Replace( "%%DATA_READERS%%", sb.ToString() );

            return sheetOutput;
        }

        private string BuildDataField( string name, ExcelColumnDataType type, int arraySize )
        {
            if( arraySize > 1 )
            {
                return $"public {ExcelTypeToManaged( type )}[] {name};";
            }
            
            return $"public {ExcelTypeToManaged( type )} {name};";
        }

        private static string Clean( string str )
        {
            if( string.IsNullOrEmpty( str ) )
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
        
        static string ExcelTypeToManaged( ExcelColumnDataType type )
        {
            switch( type )
            {
                case ExcelColumnDataType.String:
                    return "string";
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
    }
}