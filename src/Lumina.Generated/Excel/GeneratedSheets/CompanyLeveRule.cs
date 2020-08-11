// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CompanyLeveRule", columnHash: 0xcc3ad729 )]
    public class CompanyLeveRule : IExcelRow
    {
        
        public string Type;
        public LazyRow< LeveString > Objective;
        public LazyRow< LeveString > Help;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Type = parser.ReadColumn< string >( 0 );
            Objective = new LazyRow< LeveString >( lumina, parser.ReadColumn< ushort >( 1 ), language );
            Help = new LazyRow< LeveString >( lumina, parser.ReadColumn< ushort >( 2 ), language );
        }
    }
}