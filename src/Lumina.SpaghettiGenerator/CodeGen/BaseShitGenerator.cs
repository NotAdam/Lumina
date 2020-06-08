using System.Text;

namespace Lumina.SpaghettiGenerator.CodeGen
{
    public class BaseShitGenerator
    {
        public BaseShitGenerator( string typeName, string fieldName, uint columnId )
        {
            TypeName = typeName;
            FieldName = fieldName;
            ColumnId = columnId;
        }

        public string TypeName { get; set; }
        public string FieldName { get; set; }
        public uint ColumnId { get; set; }
        
        public virtual void WriteFields( StringBuilder sb )
        {
            throw new System.NotImplementedException();
        }

        public virtual void WriteReaders( StringBuilder sb )
        {
            throw new System.NotImplementedException();
        }
    }
}