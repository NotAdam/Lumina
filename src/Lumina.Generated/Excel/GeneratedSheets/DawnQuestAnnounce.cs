// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DawnQuestAnnounce", columnHash: 0xf8bddb48 )]
    public class DawnQuestAnnounce : IExcelRow
    {
        
        public LazyRow< Quest > Quest;
        public LazyRow< DawnContent > Content;
        public LazyRow< ENpcResident >[] ENPC;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Quest = new LazyRow< Quest >( lumina, parser.ReadColumn< uint >( 0 ), language );
            Content = new LazyRow< DawnContent >( lumina, parser.ReadColumn< byte >( 1 ), language );
            ENPC = new LazyRow< ENpcResident >[ 6 ];
            for( var i = 0; i < 6; i++ )
                ENPC[ i ] = new LazyRow< ENpcResident >( lumina, parser.ReadColumn< uint >( 2 + i ), language );
        }
    }
}