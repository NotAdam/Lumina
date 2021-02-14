// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GilShop", columnHash: 0xa0969241 )]
    public class GilShop : ExcelRow
    {
        
        public SeString Name;
        public uint Icon;
        public LazyRow< Quest > Quest;
        public LazyRow< DefaultTalk > AcceptTalk;
        public LazyRow< DefaultTalk > FailTalk;
        public bool Unknown5;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Name = parser.ReadColumn< SeString >( 0 );
            Icon = parser.ReadColumn< uint >( 1 );
            Quest = new LazyRow< Quest >( lumina, parser.ReadColumn< uint >( 2 ), language );
            AcceptTalk = new LazyRow< DefaultTalk >( lumina, parser.ReadColumn< int >( 3 ), language );
            FailTalk = new LazyRow< DefaultTalk >( lumina, parser.ReadColumn< int >( 4 ), language );
            Unknown5 = parser.ReadColumn< bool >( 5 );
        }
    }
}