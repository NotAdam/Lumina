// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "AirshipExplorationLevel", columnHash: 0x382abf74 )]
    public class AirshipExplorationLevel : IExcelRow
    {
        
        public ushort Unknown0;
        public uint ExpToNext;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Unknown0 = parser.ReadColumn< ushort >( 0 );
            ExpToNext = parser.ReadColumn< uint >( 1 );
        }
    }
}