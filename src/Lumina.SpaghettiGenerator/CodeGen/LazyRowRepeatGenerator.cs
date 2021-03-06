using System.Text;
using Lumina.Data.Structs.Excel;

namespace Lumina.SpaghettiGenerator.CodeGen
{
    public class LazyRowRepeatGenerator : BaseShitGenerator
    {
        private readonly ExcelColumnDefinition[] _cols;
        private uint Count { get; set; }
        
        public LazyRowRepeatGenerator( string typeName, string fieldName, uint columnId, uint count, ExcelColumnDefinition[] cols ) : base( typeName, fieldName, columnId )
        {
            _cols = cols;
            Count = count;
        }

        public override void WriteFields( StringBuilder sb )
        {
            sb.AppendLine( $"public LazyRow< {TypeName} >[] {FieldName} {{ get; set; }}" );
        }

        public override void WriteReaders( StringBuilder sb )
        {
            // todo: this won't be the same column for each but assuming the types are the same and the repeat is correct, this will just work™
            var type = SpaghettiGenerator.ExcelTypeToManaged( _cols[ ColumnId ].Type );

            if( _cols[ ColumnId ].IsBoolType )
            {
                sb.AppendLine( $"#warning generator error: the definition for this repeat ({FieldName}) has an invalid type for a LazyRow" );
                return;
            }
            
            sb.AppendLine( $"{FieldName} = new LazyRow< {TypeName} >[ {Count} ];" );
            sb.AppendLine( $"for( var i = 0; i < {Count}; i++ )" );
            sb.AppendLine( $"    {FieldName}[ i ] = new LazyRow< {TypeName} >( gameData, parser.ReadColumn< {type} >( {ColumnId} + i ), language );" );
        }
    }
}