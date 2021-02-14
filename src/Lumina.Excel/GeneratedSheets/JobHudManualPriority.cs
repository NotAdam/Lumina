// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "JobHudManualPriority", columnHash: 0x5be005ad )]
    public class JobHudManualPriority : ExcelRow
    {
        
        public LazyRow< JobHudManual >[] JobHudManual;
        public byte Unknown3;
        public byte Unknown4;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            JobHudManual = new LazyRow< JobHudManual >[ 3 ];
            for( var i = 0; i < 3; i++ )
                JobHudManual[ i ] = new LazyRow< JobHudManual >( lumina, parser.ReadColumn< byte >( 0 + i ), language );
            Unknown3 = parser.ReadColumn< byte >( 3 );
            Unknown4 = parser.ReadColumn< byte >( 4 );
        }
    }
}