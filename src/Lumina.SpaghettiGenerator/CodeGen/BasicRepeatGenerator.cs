using System.Text;

namespace Lumina.SpaghettiGenerator.CodeGen
{
    public class BasicRepeatGenerator : BaseShitGenerator
    {
        public uint Count { get; set; }
        
        public BasicRepeatGenerator( string typeName, string fieldName, uint columnId, uint count ) : base( typeName, fieldName, columnId )
        {
            Count = count;
        }

        public override void WriteFields( StringBuilder sb )
        {
            sb.AppendLine( $"public {TypeName}[] {FieldName};" );
        }

        public override void WriteReaders( StringBuilder sb )
        {
            sb.AppendLine( $"for( var i = 0; i < {Count}; i++ )" );
            sb.AppendLine( $"    {FieldName}[ i ] = reader.ReadColumn< {TypeName} >( {ColumnId} + i );" );
        }
    }
}