// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "TutorialTank", columnHash: 0xdcfd9eba )]
    public class TutorialTank : IExcelRow
    {
        
        public LazyRow< Tutorial > Objective;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Objective = new LazyRow< Tutorial >( lumina, parser.ReadColumn< byte >( 0 ), language );
        }
    }
}