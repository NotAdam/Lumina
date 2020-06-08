using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "QuickChat", columnHash: 0x66d693c5 )]
    public class QuickChat : IExcelRow
    {
        
        public string NameAction;
        public int Icon;
        public LazyRow< Addon > Addon;
        public LazyRow< QuickChatTransient > QuickChatTransient;
        public ushort Unknown4;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            NameAction = parser.ReadColumn< string >( 0 );
            Icon = parser.ReadColumn< int >( 1 );
            Addon = new LazyRow< Addon >( lumina, parser.ReadColumn< int >( 2 ) );
            QuickChatTransient = new LazyRow< QuickChatTransient >( lumina, parser.ReadColumn< sbyte >( 3 ) );
            Unknown4 = parser.ReadColumn< ushort >( 4 );
        }
    }
}