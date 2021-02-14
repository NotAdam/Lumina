// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "PartyContentCutscene", columnHash: 0x5d58cc84 )]
    public class PartyContentCutscene : ExcelRow
    {
        
        public LazyRow< Cutscene > Cutscene;
        public uint Unknown1;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Cutscene = new LazyRow< Cutscene >( lumina, parser.ReadColumn< uint >( 0 ), language );
            Unknown1 = parser.ReadColumn< uint >( 1 );
        }
    }
}