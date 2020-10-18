// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ContentRouletteOpenRule", columnHash: 0x985449ce )]
    public class ContentRouletteOpenRule : IExcelRow
    {
        
        public bool Unknown0;
        public uint Type;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Unknown0 = parser.ReadColumn< bool >( 0 );
            Type = parser.ReadColumn< uint >( 1 );
        }
    }
}