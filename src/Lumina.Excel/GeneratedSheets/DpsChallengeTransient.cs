// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DpsChallengeTransient", columnHash: 0xd870e208 )]
    public class DpsChallengeTransient : ExcelRow
    {
        
        public LazyRow< InstanceContent > InstanceContent;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            InstanceContent = new LazyRow< InstanceContent >( lumina, parser.ReadColumn< ushort >( 0 ), language );
        }
    }
}