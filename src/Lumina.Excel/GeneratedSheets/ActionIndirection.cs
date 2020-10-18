// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ActionIndirection", columnHash: 0xfde405db )]
    public class ActionIndirection : IExcelRow
    {
        
        public LazyRow< Action > Name;
        public sbyte Unknown1;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Name = new LazyRow< Action >( lumina, parser.ReadColumn< int >( 0 ), language );
            Unknown1 = parser.ReadColumn< sbyte >( 1 );
        }
    }
}