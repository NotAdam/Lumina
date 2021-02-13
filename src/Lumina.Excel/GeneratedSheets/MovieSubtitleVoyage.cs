// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MovieSubtitleVoyage", columnHash: 0x07f99ad3 )]
    public class MovieSubtitleVoyage : ExcelRow
    {
        
        public float StartTime;
        public float EndTime;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            StartTime = parser.ReadColumn< float >( 0 );
            EndTime = parser.ReadColumn< float >( 1 );
        }
    }
}