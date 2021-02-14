// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HWDGathererInspectionReward", columnHash: 0x2020acf6 )]
    public class HWDGathererInspectionReward : ExcelRow
    {
        
        public ushort Scrips;
        public ushort Points;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Scrips = parser.ReadColumn< ushort >( 0 );
            Points = parser.ReadColumn< ushort >( 1 );
        }
    }
}