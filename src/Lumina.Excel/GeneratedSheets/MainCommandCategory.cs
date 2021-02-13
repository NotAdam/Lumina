// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MainCommandCategory", columnHash: 0x0c8db36c )]
    public class MainCommandCategory : ExcelRow
    {
        
        public int Unknown0;
        public SeString Name;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Unknown0 = parser.ReadColumn< int >( 0 );
            Name = parser.ReadColumn< SeString >( 1 );
        }
    }
}