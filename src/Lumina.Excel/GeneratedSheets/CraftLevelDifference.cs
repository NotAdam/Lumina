// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CraftLevelDifference", columnHash: 0xba1851a4 )]
    public class CraftLevelDifference : ExcelRow
    {
        
        public short Difference;
        public short ProgressFactor;
        public short QualityFactor;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Difference = parser.ReadColumn< short >( 0 );
            ProgressFactor = parser.ReadColumn< short >( 1 );
            QualityFactor = parser.ReadColumn< short >( 2 );
        }
    }
}