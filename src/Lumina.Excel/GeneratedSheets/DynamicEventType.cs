// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DynamicEventType", columnHash: 0x6be0e840 )]
    public class DynamicEventType : IExcelRow
    {
        
        public uint IconObjective0;
        public uint IconObjective1;
        public uint Unknown2;
        public uint Unknown3;
        public uint Unknown4;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            IconObjective0 = parser.ReadColumn< uint >( 0 );
            IconObjective1 = parser.ReadColumn< uint >( 1 );
            Unknown2 = parser.ReadColumn< uint >( 2 );
            Unknown3 = parser.ReadColumn< uint >( 3 );
            Unknown4 = parser.ReadColumn< uint >( 4 );
        }
    }
}