// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DawnQuestAnnounce", columnHash: 0xf8bddb48 )]
    public class DawnQuestAnnounce : ExcelRow
    {
        
        public LazyRow< Quest > Quest;
        public LazyRow< DawnContent > Content;
        public LazyRow< ENpcResident >[] ENPC;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Quest = new LazyRow< Quest >( lumina, parser.ReadColumn< uint >( 0 ), language );
            Content = new LazyRow< DawnContent >( lumina, parser.ReadColumn< byte >( 1 ), language );
            ENPC = new LazyRow< ENpcResident >[ 6 ];
            for( var i = 0; i < 6; i++ )
                ENPC[ i ] = new LazyRow< ENpcResident >( lumina, parser.ReadColumn< uint >( 2 + i ), language );
        }
    }
}