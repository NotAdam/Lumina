// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Condition", columnHash: 0xf234a002 )]
    public class Condition : IExcelRow
    {
        
        public bool Unknown0;
        public byte Unknown1;
        public LazyRow< LogMessage > LogMessage;
        public byte Unknown3;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Unknown0 = parser.ReadColumn< bool >( 0 );
            Unknown1 = parser.ReadColumn< byte >( 1 );
            LogMessage = new LazyRow< LogMessage >( lumina, parser.ReadColumn< uint >( 2 ), language );
            Unknown3 = parser.ReadColumn< byte >( 3 );
        }
    }
}