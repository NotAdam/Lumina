// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ContentGaugeColor", columnHash: 0x96a22aea )]
    public class ContentGaugeColor : IExcelRow
    {
        
        public uint AndroidColor1;
        public uint AndroidColor2;
        public uint AndroidColor3;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            AndroidColor1 = parser.ReadColumn< uint >( 0 );
            AndroidColor2 = parser.ReadColumn< uint >( 1 );
            AndroidColor3 = parser.ReadColumn< uint >( 2 );
        }
    }
}