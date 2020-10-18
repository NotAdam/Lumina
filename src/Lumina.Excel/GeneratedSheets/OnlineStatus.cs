// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "OnlineStatus", columnHash: 0xd87db84c )]
    public class OnlineStatus : IExcelRow
    {
        
        public bool List;
        public bool Unknown1;
        public byte Priority;
        public SeString Name;
        public uint Icon;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            List = parser.ReadColumn< bool >( 0 );
            Unknown1 = parser.ReadColumn< bool >( 1 );
            Priority = parser.ReadColumn< byte >( 2 );
            Name = parser.ReadColumn< SeString >( 3 );
            Icon = parser.ReadColumn< uint >( 4 );
        }
    }
}