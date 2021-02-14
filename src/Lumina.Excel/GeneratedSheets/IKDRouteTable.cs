// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "IKDRouteTable", columnHash: 0xdbf43666 )]
    public class IKDRouteTable : ExcelRow
    {
        
        public LazyRow< IKDRoute > Route;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Route = new LazyRow< IKDRoute >( lumina, parser.ReadColumn< uint >( 0 ), language );
        }
    }
}