// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ActionParam", columnHash: 0x8795cd75 )]
    public class ActionParam : IExcelRow
    {
        
        public short Name;
        public short Unknown1;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Name = parser.ReadColumn< short >( 0 );
            Unknown1 = parser.ReadColumn< short >( 1 );
        }
    }
}