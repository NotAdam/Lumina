// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ChocoboTaxi", columnHash: 0x6a82513f )]
    public partial class ChocoboTaxi : ExcelRow
    {
        
        public LazyRow< ChocoboTaxiStand > Location { get; set; }
        public byte Fare { get; set; }
        public ushort TimeRequired { get; set; }
        public ushort Unknown3 { get; set; }
        public bool Unknown4 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Location = new LazyRow< ChocoboTaxiStand >( gameData, parser.ReadColumn< uint >( 0 ), language );
            Fare = parser.ReadColumn< byte >( 1 );
            TimeRequired = parser.ReadColumn< ushort >( 2 );
            Unknown3 = parser.ReadColumn< ushort >( 3 );
            Unknown4 = parser.ReadColumn< bool >( 4 );
        }
    }
}