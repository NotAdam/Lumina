// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DawnMemberUIParam", columnHash: 0x0fd503c6 )]
    public class DawnMemberUIParam : ExcelRow
    {
        
        public SeString ClassSingular;
        public uint VoiceLine;
        public SeString ClassPlural;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            ClassSingular = parser.ReadColumn< SeString >( 0 );
            VoiceLine = parser.ReadColumn< uint >( 1 );
            ClassPlural = parser.ReadColumn< SeString >( 2 );
        }
    }
}