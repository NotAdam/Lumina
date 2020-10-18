// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ENpcDressUp", columnHash: 0xde74b4c4 )]
    public class ENpcDressUp : IExcelRow
    {
        
        public byte Unknown0;
        public LazyRow< ENpcDressUpDress > ENpcDressUpDress;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Unknown0 = parser.ReadColumn< byte >( 0 );
            ENpcDressUpDress = new LazyRow< ENpcDressUpDress >( lumina, parser.ReadColumn< byte >( 1 ), language );
        }
    }
}