using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MountAction", columnHash: 0x58822da3 )]
    public class MountAction : IExcelRow
    {
        
        public LazyRow< Action >[] Action;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Action = new LazyRow< Action >[ 6 ];
            for( var i = 0; i < 6; i++ )
                Action[ i ] = new LazyRow< Action >( lumina, parser.ReadColumn< ushort >( 0 + i ) );
        }
    }
}