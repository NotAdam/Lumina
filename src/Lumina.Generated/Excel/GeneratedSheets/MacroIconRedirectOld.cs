using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MacroIconRedirectOld", columnHash: 0x5c9aa6b3 )]
    public class MacroIconRedirectOld : IExcelRow
    {
        
        public uint IconOld;
        public int IconNew;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            IconOld = parser.ReadColumn< uint >( 0 );
            IconNew = parser.ReadColumn< int >( 1 );
        }
    }
}