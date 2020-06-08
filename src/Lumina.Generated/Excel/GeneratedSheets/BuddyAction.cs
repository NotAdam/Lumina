using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "BuddyAction", columnHash: 0x9a695bec )]
    public class BuddyAction : IExcelRow
    {
        
        public string Name;
        public string Description;
        public int Icon;
        public int IconStatus;
        public ushort Reward;
        public byte Sort;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Name = parser.ReadColumn< string >( 0 );
            Description = parser.ReadColumn< string >( 1 );
            Icon = parser.ReadColumn< int >( 2 );
            IconStatus = parser.ReadColumn< int >( 3 );
            Reward = parser.ReadColumn< ushort >( 4 );
            Sort = parser.ReadColumn< byte >( 5 );
        }
    }
}