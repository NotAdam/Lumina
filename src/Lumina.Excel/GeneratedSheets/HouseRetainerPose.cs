// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HouseRetainerPose", columnHash: 0xd870e208 )]
    public class HouseRetainerPose : ExcelRow
    {
        
        public LazyRow< ActionTimeline > ActionTimeline;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            ActionTimeline = new LazyRow< ActionTimeline >( lumina, parser.ReadColumn< ushort >( 0 ), language );
        }
    }
}