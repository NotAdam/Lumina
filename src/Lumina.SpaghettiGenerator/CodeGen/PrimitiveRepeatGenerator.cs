using System.Text;

namespace Lumina.SpaghettiGenerator.CodeGen
{
    public class PrimitiveRepeatGenerator : BaseShitGenerator
    {
        public uint Count { get; set; }
        
        public PrimitiveRepeatGenerator( string typeName, string fieldName, uint columnId, uint count ) : base( typeName, fieldName, columnId )
        {
            Count = count;
        }

        public override void WriteFields( StringBuilder sb )
        {
            sb.AppendLine( $"public {TypeName}[] {FieldName} {{ get; set; }}" );
        }

        public override void WriteReaders( StringBuilder sb )
        {
            sb.AppendLine( $"{FieldName} = new {TypeName}[ {Count} ];" );
            sb.AppendLine( $"for( var i = 0; i < {Count}; i++ )" );
            sb.AppendLine( $"    {FieldName}[ i ] = parser.ReadColumn< {TypeName} >( {ColumnId} + i );" );
        }
    }
}