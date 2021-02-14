// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Tomestones", columnHash: 0xd870e208 )]
    public class Tomestones : ExcelRow
    {
        
        public ushort WeeklyLimit;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            WeeklyLimit = parser.ReadColumn< ushort >( 0 );
        }
    }
}