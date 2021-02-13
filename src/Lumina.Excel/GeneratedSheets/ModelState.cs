// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ModelState", columnHash: 0xd73eab80 )]
    public class ModelState : ExcelRow
    {
        
        public byte Unknown0;
        public LazyRow< ActionTimeline > Start;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Unknown0 = parser.ReadColumn< byte >( 0 );
            Start = new LazyRow< ActionTimeline >( lumina, parser.ReadColumn< ushort >( 1 ), language );
        }
    }
}