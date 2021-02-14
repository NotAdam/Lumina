// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ContentsTutorialPage", columnHash: 0x0c8db36c )]
    public class ContentsTutorialPage : ExcelRow
    {
        
        public int Image;
        public SeString Description;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Image = parser.ReadColumn< int >( 0 );
            Description = parser.ReadColumn< SeString >( 1 );
        }
    }
}