// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MountTransient", columnHash: 0x7f711762 )]
    public class MountTransient : ExcelRow
    {
        
        public SeString Description;
        public SeString DescriptionEnhanced;
        public SeString Tooltip;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Description = parser.ReadColumn< SeString >( 0 );
            DescriptionEnhanced = parser.ReadColumn< SeString >( 1 );
            Tooltip = parser.ReadColumn< SeString >( 2 );
        }
    }
}