using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "LeveAssignmentType", columnHash: 0x7c19f23c )]
    public class LeveAssignmentType : IExcelRow
    {
        
        public bool IsFaction;
        public int Icon;
        public string Name;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            IsFaction = parser.ReadColumn< bool >( 0 );
            Icon = parser.ReadColumn< int >( 1 );
            Name = parser.ReadColumn< string >( 2 );
        }
    }
}