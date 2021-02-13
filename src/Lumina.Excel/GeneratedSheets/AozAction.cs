// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "AozAction", columnHash: 0x5a516458 )]
    public class AozAction : ExcelRow
    {
        
        public LazyRow< Action > Action;
        public byte Unknown1;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Action = new LazyRow< Action >( lumina, parser.ReadColumn< uint >( 0 ), language );
            Unknown1 = parser.ReadColumn< byte >( 1 );
        }
    }
}