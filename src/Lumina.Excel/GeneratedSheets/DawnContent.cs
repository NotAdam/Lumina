// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DawnContent", columnHash: 0x5d58cc84 )]
    public class DawnContent : ExcelRow
    {
        
        public LazyRow< ContentFinderCondition > Content;
        public uint Exp;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Content = new LazyRow< ContentFinderCondition >( lumina, parser.ReadColumn< uint >( 0 ), language );
            Exp = parser.ReadColumn< uint >( 1 );
        }
    }
}