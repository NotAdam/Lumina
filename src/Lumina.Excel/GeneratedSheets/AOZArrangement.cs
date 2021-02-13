// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "AOZArrangement", columnHash: 0x2020acf6 )]
    public class AOZArrangement : ExcelRow
    {
        
        public LazyRow< AOZContentBriefingBNpc > AOZContentBriefingBNpc;
        public ushort Position;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            AOZContentBriefingBNpc = new LazyRow< AOZContentBriefingBNpc >( lumina, parser.ReadColumn< ushort >( 0 ), language );
            Position = parser.ReadColumn< ushort >( 1 );
        }
    }
}