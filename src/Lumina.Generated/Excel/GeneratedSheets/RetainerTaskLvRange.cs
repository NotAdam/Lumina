// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "RetainerTaskLvRange", columnHash: 0xde74b4c4 )]
    public class RetainerTaskLvRange : IExcelRow
    {
        
        public byte Min;
        public byte Max;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Min = parser.ReadColumn< byte >( 0 );
            Max = parser.ReadColumn< byte >( 1 );
        }
    }
}