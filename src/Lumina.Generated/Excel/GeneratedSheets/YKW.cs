using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "YKW", columnHash: 0xa866cd57 )]
    public class YKW : IExcelRow
    {
        
        public ushort Unknown0;
        public LazyRow< Item > Item;
        public LazyRow< TerritoryType >[] Location;
        public string Unknown5;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Unknown0 = parser.ReadColumn< ushort >( 0 );
            Item = new LazyRow< Item >( lumina, parser.ReadColumn< uint >( 1 ) );
            for( var i = 0; i < 3; i++ )
                Location[ i ] = new LazyRow< TerritoryType >( lumina, parser.ReadColumn< ushort >( 2 + i ) );
            Unknown5 = parser.ReadColumn< string >( 5 );
        }
    }
}