// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Calendar", columnHash: 0x005cfabb )]
    public class Calendar : IExcelRow
    {
        
        public byte[] Month;
        public byte[] Day;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Month = new byte[ 32 ];
            for( var i = 0; i < 32; i++ )
                Month[ i ] = parser.ReadColumn< byte >( 0 + i );
            Day = new byte[ 32 ];
            for( var i = 0; i < 32; i++ )
                Day[ i ] = parser.ReadColumn< byte >( 32 + i );
        }
    }
}