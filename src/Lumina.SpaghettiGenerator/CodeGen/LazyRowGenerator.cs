using System.Text;

namespace Lumina.SpaghettiGenerator.CodeGen
{
    public class LazyRowGenerator : BaseShitGenerator
    {
        public LazyRowGenerator( string typeName, string fieldName, uint columnId ) : base( typeName, fieldName, columnId )
        {
        }
        
        public override void WriteFields( StringBuilder sb )
        {
            sb.AppendLine( $"public LazyRow< {TypeName} > {FieldName};" );
        }

        public override void WriteReaders( StringBuilder sb )
        {
            sb.AppendLine( $"{FieldName} = new LazyRow< {TypeName} >( lumina, reader.ReadColumn< uint >( {ColumnId} ) );" );
        }
    }
}