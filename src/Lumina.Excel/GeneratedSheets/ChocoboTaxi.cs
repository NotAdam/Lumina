// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ChocoboTaxi", columnHash: 0x121fc5dc )]
    public class ChocoboTaxi : ExcelRow
    {
        
        public LazyRow< ChocoboTaxiStand > Location;
        public byte Fare;
        public ushort TimeRequired;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Location = new LazyRow< ChocoboTaxiStand >( lumina, parser.ReadColumn< uint >( 0 ), language );
            Fare = parser.ReadColumn< byte >( 1 );
            TimeRequired = parser.ReadColumn< ushort >( 2 );
        }
    }
}