// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ChocoboTaxi", columnHash: 0x121fc5dc )]
    public class ChocoboTaxi : IExcelRow
    {
        
        public LazyRow< ChocoboTaxiStand > Location;
        public byte Fare;
        public ushort TimeRequired;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Location = new LazyRow< ChocoboTaxiStand >( lumina, parser.ReadColumn< uint >( 0 ), language );
            Fare = parser.ReadColumn< byte >( 1 );
            TimeRequired = parser.ReadColumn< ushort >( 2 );
        }
    }
}