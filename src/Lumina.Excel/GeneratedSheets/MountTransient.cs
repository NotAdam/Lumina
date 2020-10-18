// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MountTransient", columnHash: 0x7f711762 )]
    public class MountTransient : IExcelRow
    {
        
        public SeString Description;
        public SeString DescriptionEnhanced;
        public SeString Tooltip;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Description = parser.ReadColumn< SeString >( 0 );
            DescriptionEnhanced = parser.ReadColumn< SeString >( 1 );
            Tooltip = parser.ReadColumn< SeString >( 2 );
        }
    }
}