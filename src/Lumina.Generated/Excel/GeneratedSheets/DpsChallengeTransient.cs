// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DpsChallengeTransient", columnHash: 0xd870e208 )]
    public class DpsChallengeTransient : IExcelRow
    {
        
        public LazyRow< InstanceContent > InstanceContent;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            InstanceContent = new LazyRow< InstanceContent >( lumina, parser.ReadColumn< ushort >( 0 ), language );
        }
    }
}