using System.Text;
using Lumina.Data.Structs.Excel;

namespace Lumina.SpaghettiGenerator.CodeGen
{
    public class LazyRowGenerator : BaseShitGenerator
    {
        private readonly ExcelColumnDefinition[] _cols;

        public LazyRowGenerator( string typeName, string fieldName, uint columnId, ExcelColumnDefinition[] cols ) : base( typeName, fieldName, columnId )
        {
            _cols = cols;
        }
        
        public override void WriteFields( StringBuilder sb )
        {
            sb.AppendLine( $"public LazyRow< {TypeName} > {FieldName};" );
        }

        public override void WriteReaders( StringBuilder sb )
        {
            if( _cols[ ColumnId ].IsBoolType )
            {
                sb.AppendLine( $"#warning generator error: the definition for this field ({FieldName}) has an invalid type for a LazyRow" );
                return;
            }
            
            var type = Program.ExcelTypeToManaged( _cols[ ColumnId ].Type );
            sb.AppendLine( $"{FieldName} = new LazyRow< {TypeName} >( lumina, parser.ReadColumn< {type} >( {ColumnId} ) );" );
        }
    }
}