// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Marker", columnHash: 0x0c8db36c )]
    public class Marker : ExcelRow
    {
        
        public int Icon;
        public SeString Name;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Icon = parser.ReadColumn< int >( 0 );
            Name = parser.ReadColumn< SeString >( 1 );
        }
    }
}