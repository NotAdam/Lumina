// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ExportedGatheringPoint", columnHash: 0xda46099c )]
    public partial class ExportedGatheringPoint : ExcelRow
    {
        
        public float X { get; set; }
        public float Y { get; set; }
        public LazyRow< GatheringType > GatheringType { get; set; }
        public byte GatheringPointType { get; set; }
        public ushort Radius { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            X = parser.ReadColumn< float >( 0 );
            Y = parser.ReadColumn< float >( 1 );
            GatheringType = new LazyRow< GatheringType >( gameData, parser.ReadColumn< byte >( 2 ), language );
            GatheringPointType = parser.ReadColumn< byte >( 3 );
            Radius = parser.ReadColumn< ushort >( 4 );
        }
    }
}