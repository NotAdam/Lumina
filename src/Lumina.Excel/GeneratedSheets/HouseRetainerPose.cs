// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HouseRetainerPose", columnHash: 0xd870e208 )]
    public partial class HouseRetainerPose : ExcelRow
    {
        
        public LazyRow< ActionTimeline > ActionTimeline { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            ActionTimeline = new LazyRow< ActionTimeline >( gameData, parser.ReadColumn< ushort >( 0 ), language );
        }
    }
}