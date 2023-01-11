// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "IKDRouteTable", columnHash: 0xdbf43666 )]
    public partial class IKDRouteTable : ExcelRow
    {
        
        public LazyRow< IKDRoute > Route { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Route = new LazyRow< IKDRoute >( gameData, parser.ReadColumn< uint >( 0 ), language );
        }
    }
}