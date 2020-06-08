using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "BuddyRank", columnHash: 0xdbf43666 )]
    public class BuddyRank : IExcelRow
    {
        
        public uint ExpRequired;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            ExpRequired = parser.ReadColumn< uint >( 0 );
        }
    }
}