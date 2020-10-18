// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "SkyIsland2MissionType", columnHash: 0xcd4cb81c )]
    public class SkyIsland2MissionType : IExcelRow
    {
        
        public bool Type;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Type = parser.ReadColumn< bool >( 0 );
        }
    }
}