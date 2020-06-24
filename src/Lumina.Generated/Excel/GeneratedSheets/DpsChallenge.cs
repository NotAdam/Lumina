using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DpsChallenge", columnHash: 0x944cf024 )]
    public class DpsChallenge : IExcelRow
    {
        
        public ushort PlayerLevel;
        public LazyRow< PlaceName > PlaceName;
        public uint Icon;
        public ushort Order;
        public string Name;
        public string Description;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            PlayerLevel = parser.ReadColumn< ushort >( 0 );
            PlaceName = new LazyRow< PlaceName >( lumina, parser.ReadColumn< ushort >( 1 ), language );
            Icon = parser.ReadColumn< uint >( 2 );
            Order = parser.ReadColumn< ushort >( 3 );
            Name = parser.ReadColumn< string >( 4 );
            Description = parser.ReadColumn< string >( 5 );
        }
    }
}