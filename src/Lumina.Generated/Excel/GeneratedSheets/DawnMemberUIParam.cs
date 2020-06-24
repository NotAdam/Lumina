using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DawnMemberUIParam", columnHash: 0x0fd503c6 )]
    public class DawnMemberUIParam : IExcelRow
    {
        
        public string ClassSingular;
        public uint VoiceLine;
        public string ClassPlural;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            ClassSingular = parser.ReadColumn< string >( 0 );
            VoiceLine = parser.ReadColumn< uint >( 1 );
            ClassPlural = parser.ReadColumn< string >( 2 );
        }
    }
}