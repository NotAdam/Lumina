using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GuideTitle", columnHash: 0x9db0e48f )]
    public class GuideTitle : IExcelRow
    {
        
        public string Title;
        public string Unknown1;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Title = parser.ReadColumn< string >( 0 );
            Unknown1 = parser.ReadColumn< string >( 1 );
        }
    }
}