// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "AozAction", columnHash: 0x5a516458 )]
    public class AozAction : IExcelRow
    {
        
        public LazyRow< Action > Action;
        public byte Unknown1;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Action = new LazyRow< Action >( lumina, parser.ReadColumn< uint >( 0 ), language );
            Unknown1 = parser.ReadColumn< byte >( 1 );
        }
    }
}