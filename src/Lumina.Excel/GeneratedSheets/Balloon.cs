// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Balloon", columnHash: 0x9d1b5f4b )]
    public class Balloon : ExcelRow
    {
        
        public bool Slowly;
        public SeString Dialogue;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Slowly = parser.ReadColumn< bool >( 0 );
            Dialogue = parser.ReadColumn< SeString >( 1 );
        }
    }
}