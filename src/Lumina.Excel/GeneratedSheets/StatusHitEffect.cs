// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "StatusHitEffect", columnHash: 0xd870e208 )]
    public class StatusHitEffect : ExcelRow
    {
        
        public LazyRow< VFX > Location;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Location = new LazyRow< VFX >( lumina, parser.ReadColumn< ushort >( 0 ), language );
        }
    }
}