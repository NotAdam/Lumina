// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "LeveVfx", columnHash: 0x993d983d )]
    public class LeveVfx : ExcelRow
    {
        
        public SeString Effect;
        public int Icon;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Effect = parser.ReadColumn< SeString >( 0 );
            Icon = parser.ReadColumn< int >( 1 );
        }
    }
}