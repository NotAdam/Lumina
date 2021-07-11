using System.Collections.Generic;
using System.Text;
using Lumina.Data.Structs.Excel;

namespace Lumina.SpaghettiGenerator.CodeGen
{
    public class GroupStructGenerator : BaseShitGenerator
    {
        private readonly List< RootDefinition > _members;
        private readonly uint _count;
        private readonly ExcelColumnDefinition[] _columns;

        public GroupStructGenerator( string typeName, string fieldName, uint columnId, List< RootDefinition > members, uint count, ExcelColumnDefinition[] columns ) :
            base( typeName, fieldName, columnId )
        {
            _members = members;
            _count = count;
            _columns = columns;
        }

        public override void WriteFields( StringBuilder sb )
        {
            sb.AppendLine( $"public {TypeName}[] {FieldName} {{ get; set; }}" );
        }

        public override void WriteReaders( StringBuilder sb )
        {
            sb.AppendLine( $"{FieldName} = new {TypeName}[ {_count} ];" );
            sb.AppendLine( $"for( var i = 0; i < {_count}; i++ )" );
            sb.AppendLine( "{" );

            sb.AppendLine( $"    {FieldName}[ i ] = new {TypeName}();" );

            for( var i = 0; i < _members.Count; i++ )
            {
                var member = _members[ i ];
                
                // this will actually return the wrong column, but if the groups are correct that won't be an issue
                // todo: ^ still fucked up though
                var col = _columns[ ColumnId + i ];

                var type = SpaghettiGenerator.ExcelTypeToManaged( col.Type );

                sb.AppendLine( $"    {FieldName}[ i ].{SpaghettiGenerator.Clean( member.Name )} = parser.ReadColumn< {type} >( {ColumnId} + ( i * {_members.Count} + {i} ) );" );
            }

            sb.AppendLine( "}" );
        }

        public override void WriteStructs( StringBuilder sb )
        {
            sb.AppendLine( $"public class {TypeName}" );
            sb.AppendLine( "{" );

            for( var i = 0; i < _members.Count; i++ )
            {
                var member = _members[ i ];
                // todo: see todo in writereaders
                var col = _columns[ ColumnId + i ];
                
                var type = SpaghettiGenerator.ExcelTypeToManaged( col.Type );

                sb.AppendLine( $"    public {type} {SpaghettiGenerator.Clean( member.Name )} {{ get; set; }}" );
            }

            sb.AppendLine( "}" );
        }
    }
}