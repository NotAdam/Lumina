// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HWDSharedGroupControlParam", columnHash: 0xde74b4c4 )]
    public class HWDSharedGroupControlParam : IExcelRow
    {
        
        public byte Unknown0;
        public byte ParamValue;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Unknown0 = parser.ReadColumn< byte >( 0 );
            ParamValue = parser.ReadColumn< byte >( 1 );
        }
    }
}