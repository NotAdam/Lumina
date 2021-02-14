// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CircleActivity", columnHash: 0x1a6ae0b3 )]
    public class CircleActivity : ExcelRow
    {
        
        public SeString Name;
        public int Icon;
        public ushort Order;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Name = parser.ReadColumn< SeString >( 0 );
            Icon = parser.ReadColumn< int >( 1 );
            Order = parser.ReadColumn< ushort >( 2 );
        }
    }
}