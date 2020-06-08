using System.Text;

namespace Lumina.SpaghettiGenerator.CodeGen
{
    public class LazyRowRepeatGenerator : BaseShitGenerator
    {
        public uint Count { get; set; }
        
        public LazyRowRepeatGenerator( string typeName, string fieldName, uint columnId, uint count ) : base( typeName, fieldName, columnId )
        {
            Count = count;
        }

        public override void WriteFields( StringBuilder sb )
        {
            sb.AppendLine( $"public LazyRow< {TypeName} >[] {FieldName};" );
        }

        public override void WriteReaders( StringBuilder sb )
        {
            sb.AppendLine( $"for( var i = 0; i < {Count}; i++ )" );
            sb.AppendLine( $"    {FieldName}[ i ] = new LazyRow< {TypeName} >( lumina, reader.ReadColumn< uint >( {ColumnId} + i ) );" );
        }
    }
}