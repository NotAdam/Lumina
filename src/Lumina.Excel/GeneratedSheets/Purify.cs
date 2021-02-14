// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Purify", columnHash: 0xde74b4c4 )]
    public class Purify : ExcelRow
    {
        
        public LazyRow< ClassJob > Class;
        public byte Level;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Class = new LazyRow< ClassJob >( lumina, parser.ReadColumn< byte >( 0 ), language );
            Level = parser.ReadColumn< byte >( 1 );
        }
    }
}