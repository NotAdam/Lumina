// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MountTransient", columnHash: 0x7f711762 )]
    public class MountTransient : IExcelRow
    {
        
        public string Description;
        public string DescriptionEnhanced;
        public string Tooltip;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Description = parser.ReadColumn< string >( 0 );
            DescriptionEnhanced = parser.ReadColumn< string >( 1 );
            Tooltip = parser.ReadColumn< string >( 2 );
        }
    }
}