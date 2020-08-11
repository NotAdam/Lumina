// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "IKDRouteTable", columnHash: 0xdbf43666 )]
    public class IKDRouteTable : IExcelRow
    {
        
        public LazyRow< IKDRoute > Route;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Route = new LazyRow< IKDRoute >( lumina, parser.ReadColumn< uint >( 0 ), language );
        }
    }
}