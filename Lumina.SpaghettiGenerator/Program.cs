using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;
using Newtonsoft.Json;

namespace Lumina.SpaghettiGenerator
{
    class DummyExcelSheet : IExcelRow
    {
        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
        }
    }

    class DataMembers
    {
        public string Name { get; set; }
        public int ArrayIndex { get; set; }
        public int Offset { get; set; }
        public int Bit { get; set; }
        public ExcelColumnDataType Type { get; set; }
    }

    class GeneratedColumnDef
    {
        public int Id { get; set; }
        public ExcelColumnDefinition ColumnDefinition { get; set; }

        public bool IsBitfield { get; set; }
        public bool IsArray { get; set; }
        public int ArraySize { get; set; }
        public int Offset { get; set; }

        public RootDefinition RootDefinition { get; set; }

        public List< DataMembers > Members { get; set; }

        public string Name
        {
            get
            {
                if( RootDefinition?.RealName != null )
                    return RootDefinition.RealName;

                if( IsBitfield )
                    return $"packed{Offset:x}";

                return $"unknown{Offset:x}";
            }
        }

        public string CleanName => Program.Clean( Name );
    }

    class Program
    {
        private static Lumina _lumina;
        private static string _sheetTemplate;

        internal static string Clean( string str )
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

        // that's amore
        static void Main( string[] args )
        {
            _lumina = new Lumina( args[ 0 ] );
            _sheetTemplate = File.ReadAllText( "class.tmpl" );

            Directory.CreateDirectory( "output" );

            // ProcessSheet( "AchievementCategory" );

            foreach( var file in Directory.EnumerateFiles( "./Definitions/", "*.json" ) )
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
        }

        static string ProcessSheet( string name )
        {
            var path = $"./Definitions/{name}.json";
            var lastModified = System.IO.File.GetLastWriteTime( path );
            var def = File.ReadAllText( path );
            var tmpl = _sheetTemplate;

            var sheet = _lumina.Excel.GetSheet< DummyExcelSheet >( name );
            if( sheet == null )
            {
                Console.WriteLine( $" - sheet {name} no longer exists!" );
                return null;
            }

            var cols = sheet.Columns;

            var schema = JsonConvert.DeserializeObject< SheetDefinition >( def );

            var items = new Dictionary< int, GeneratedColumnDef >();

            var doneCols = new List< int >();

            for( int i = 0; i < cols.Length; i++ )
            {
                if( doneCols.Contains( i ) )
                {
                    continue;
                }

                ref var colDef = ref cols[ i ];

                var schemaDef = schema.Definitions.FirstOrDefault( d => d.Index == i );

                GeneratedColumnDef col;
                if( !items.TryGetValue( colDef.Offset, out col ) )
                {
                    col = new GeneratedColumnDef
                    {
                        ColumnDefinition = colDef,
                        Id = i,
                        RootDefinition = schemaDef,
                        Offset = colDef.Offset
                    };

                    items[ colDef.Offset ] = col;
                }

                var bool0 = (int)ExcelColumnDataType.PackedBool0;
                var intType = (int)colDef.Type;
                if( intType >= bool0 )
                {
                    col.IsBitfield = true;
                }

                col.Members ??= new List< DataMembers >();

                var rootMember = new DataMembers
                {
                    Name = schemaDef?.RealName,
                    Offset = colDef.Offset,
                    Type = colDef.Type,
                    Bit = 1 << ( intType - bool0 )
                };

                col.Members.Add( rootMember );

                if( schemaDef != null )
                {
                    if( schemaDef.Type == "repeat" )
                    {
                        col.IsArray = true;
                        col.ArraySize = schemaDef.Count;

                        rootMember.ArrayIndex = 0;

                        for( int j = 1; j < col.ArraySize; j++ )
                        {
                            doneCols.Add( i + j );

                            var newCol = cols[ i + j ];

                            col.Members.Add( new DataMembers
                            {
                                Offset = newCol.Offset,
                                Type = newCol.Type,
                                ArrayIndex = j
                            } );
                        }
                    }
                }

                doneCols.Add( i );
            }

            // no hate pls
            var indent = "        ";

            tmpl = tmpl.Replace( "%%SHEET_NAME%%", name );
            var hash = sheet.HeaderFile.GetColumnsHash();
            tmpl = tmpl.Replace( "%%COL_HASH%%", $"0x{hash:x8}" );

            var sb = new StringBuilder();

            sb.Append( indent );
            sb.Append( $"// column defs from {lastModified:R}" );
            sb.AppendLine();
            sb.AppendLine();

            tmpl = tmpl.Replace( "%%DEBUG_INFO%%", sb.ToString() );

            sb.Clear();
            foreach( var (offset, gcd) in items.OrderBy( pair => pair.Key ) )
            {
                var typeName = ExcelTypeToManaged( gcd.ColumnDefinition.Type );

                // add comment
                sb.Append( indent );
                sb.Append( $"// col: {gcd.Id:00} offset: {offset:x4}" );
                sb.AppendLine();

                if( gcd.IsBitfield )
                {
                    sb.Append( indent );
                    // yes i hate myself 
                    // no i don't care
                    sb.Append( GenerateDataMember( "byte", $"packed{offset:x}", offset ).Replace( "public", "private" ) );
                    sb.AppendLine();

                    // time to hate myself even more
                    int index = 0;
                    foreach( var member in gcd.Members )
                    {
                        var bit = 1 << index;
                        var defaultName = $"packed{offset:x}_{bit:x}";

                        sb.Append( indent );
                        sb.Append( $"public bool {Clean( member.Name ) ?? defaultName} => ( packed{offset:x} & 0x{bit:x} ) == 0x{bit:x};" );
                        sb.AppendLine();

                        index++;
                    }
                }
                else
                {
                    sb.Append( indent );
                    sb.Append( GenerateDataMember( typeName, gcd.CleanName, offset, gcd.ArraySize ) );
                    sb.AppendLine();
                }

                sb.AppendLine();
            }

            tmpl = tmpl.Replace( "%%DATA_MEMBERS%%", sb.ToString() );

            // no hate plssss
            indent = "            ";

            sb.Clear();
            foreach( var (offset, gcd) in items.OrderBy( pair => pair.Key ) )
            {
                var typeName = ExcelTypeToManaged( gcd.ColumnDefinition.Type );

                // add comment
                sb.Append( indent );
                sb.Append( $"// col: {gcd.Id} offset: {offset:x4}" );
                sb.AppendLine();

                if( gcd.IsBitfield )
                {
                    sb.Append( indent );
                    sb.Append( GenerateReadMember( "byte", $"packed{offset:x}", offset, -1, true ) );
                    sb.AppendLine();
                    sb.AppendLine();

                    continue;
                }
                // ReSharper disable once RedundantIfElseBlock
                else if( gcd.IsArray )
                {
                    sb.Append( indent );
                    sb.Append( $"{gcd.CleanName} = new {typeName}[{gcd.ArraySize}];" );
                    sb.AppendLine();
                }

                foreach( var member in gcd.Members )
                {
                    sb.Append( indent );

                    if( gcd.IsArray )
                    {
                        // todo: left as straight reads because exds can have nested structures which then read incorrectly if you do a batch read
                        sb.Append( GenerateReadMember( typeName, gcd.CleanName, member.Offset, member.ArrayIndex ) );
                    }

                    else
                    {
                        sb.Append( GenerateReadMember( typeName, gcd.CleanName, member.Offset ) );
                    }

                    sb.AppendLine();
                }

                sb.AppendLine();
            }

            tmpl = tmpl.Replace( "%%DATA_READERS%%", sb.ToString() );

            return tmpl;
        }

        static string GenerateDataMember( string type, string name, int offset, int arraySize = 0 )
        {
            var arrayStr = "";
            if( arraySize > 0 )
            {
                arrayStr = $"[]";
            }

            if( string.IsNullOrEmpty( name ) )
            {
                return $"public {type}{arrayStr} unknown{offset:x};";
            }

            return $"public {type}{arrayStr} {name};";
        }

        static string GenerateReadMember( string type, string name, int offset, int arrayIndex = -1, bool bitset = false )
        {
            var arrayStr = "";
            if( arrayIndex > -1 )
            {
                arrayStr = $"[{arrayIndex}]";
            }

            var bitsetType = "";
            if( bitset )
            {
                bitsetType = ", ExcelColumnDataType.UInt8";
            }

            if( string.IsNullOrEmpty( name ) )
            {
                return $"unknown{offset:x}{arrayStr} = parser.ReadOffset< {type} >( 0x{offset:x}{bitsetType} );";
            }

            return $"{name}{arrayStr} = parser.ReadOffset< {type} >( 0x{offset:x}{bitsetType} );";
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