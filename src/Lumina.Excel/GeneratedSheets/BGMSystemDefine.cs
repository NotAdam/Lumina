// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "BGMSystemDefine", columnHash: 0xd16a1b6c )]
    public class BGMSystemDefine : IExcelRow
    {
        
        public float Define;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Define = parser.ReadColumn< float >( 0 );
        }
    }
}