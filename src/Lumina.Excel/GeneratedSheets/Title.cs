// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Title", columnHash: 0x83e3f9ba )]
    public class Title : ExcelRow
    {
        
        public SeString Masculine;
        public SeString Feminine;
        public bool IsPrefix;
        public ushort Order;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Masculine = parser.ReadColumn< SeString >( 0 );
            Feminine = parser.ReadColumn< SeString >( 1 );
            IsPrefix = parser.ReadColumn< bool >( 2 );
            Order = parser.ReadColumn< ushort >( 3 );
        }
    }
}