using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "QuestRewardOther", columnHash: 0xaafab8d8 )]
    public class QuestRewardOther : IExcelRow
    {
        
        public uint Icon;
        public string Name;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Icon = parser.ReadColumn< uint >( 0 );
            Name = parser.ReadColumn< string >( 1 );
        }
    }
}