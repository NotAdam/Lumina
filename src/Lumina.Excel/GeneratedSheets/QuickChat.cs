// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "QuickChat", columnHash: 0x66d693c5 )]
    public class QuickChat : IExcelRow
    {
        
        public SeString NameAction;
        public int Icon;
        public LazyRow< Addon > Addon;
        public LazyRow< QuickChatTransient > QuickChatTransient;
        public ushort Unknown4;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            NameAction = parser.ReadColumn< SeString >( 0 );
            Icon = parser.ReadColumn< int >( 1 );
            Addon = new LazyRow< Addon >( lumina, parser.ReadColumn< int >( 2 ), language );
            QuickChatTransient = new LazyRow< QuickChatTransient >( lumina, parser.ReadColumn< sbyte >( 3 ), language );
            Unknown4 = parser.ReadColumn< ushort >( 4 );
        }
    }
}