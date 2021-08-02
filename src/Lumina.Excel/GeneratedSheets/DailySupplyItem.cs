// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DailySupplyItem", columnHash: 0x5e7b2507 )]
    public class DailySupplyItem : ExcelRow
    {
        public class SupplyItem
        {
            public int Item { get; set; }
            public byte Quantity { get; set; }
            public byte RecipeLevel { get; set; }
        }
        
        public SupplyItem[] SupplyItems { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            SupplyItems = new SupplyItem[ 8 ];
            for( var i = 0; i < 8; i++ )
            {
                SupplyItems[ i ] = new SupplyItem();
                SupplyItems[ i ].Item = parser.ReadColumn< int >( 0 + ( i * 3 + 0 ) );
                SupplyItems[ i ].Quantity = parser.ReadColumn< byte >( 0 + ( i * 3 + 1 ) );
                SupplyItems[ i ].RecipeLevel = parser.ReadColumn< byte >( 0 + ( i * 3 + 2 ) );
            }
        }
    }
}