using System.Text;

namespace Lumina.SpaghettiGenerator.CodeGen
{
    public class PrimitiveGenerator : BaseShitGenerator
    {
        public PrimitiveGenerator( string typeName, string fieldName, uint columnId ) : base( typeName, fieldName, columnId )
        {
        }

        public override void WriteFields( StringBuilder sb )
        {
            sb.AppendLine( $"public {TypeName} {FieldName} {{ get; set; }}" );
        }

        public override void WriteReaders( StringBuilder sb )
        {
            sb.AppendLine( $"{FieldName} = parser.ReadColumn< {TypeName} >( {ColumnId} );" );
        }
    }
}