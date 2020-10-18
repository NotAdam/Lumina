// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "BGMFadeType", columnHash: 0xe018b5fa )]
    public class BGMFadeType : IExcelRow
    {
        
        public float FadeOutTime;
        public float FadeInTime;
        public float FadeInStartTime;
        public float ResumeFadeInTime;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            FadeOutTime = parser.ReadColumn< float >( 0 );
            FadeInTime = parser.ReadColumn< float >( 1 );
            FadeInStartTime = parser.ReadColumn< float >( 2 );
            ResumeFadeInTime = parser.ReadColumn< float >( 3 );
        }
    }
}