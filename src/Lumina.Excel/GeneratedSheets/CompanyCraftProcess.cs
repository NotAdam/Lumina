// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CompanyCraftProcess", columnHash: 0x3135b48e )]
    public class CompanyCraftProcess : ExcelRow
    {
        public class CompanyCraftItem
        {
            public ushort SupplyItem { get; set; }
            public ushort SetQuantity { get; set; }
            public ushort SetsRequired { get; set; }
        }
        
        public CompanyCraftItem[] Items { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Items = new CompanyCraftItem[ 12 ];
            for( var i = 0; i < 12; i++ )
            {
                Items[ i ] = new CompanyCraftItem();
                Items[ i ].SupplyItem = parser.ReadColumn< ushort >( 0 + ( i * 3 + 0 ) );
                Items[ i ].SetQuantity = parser.ReadColumn< ushort >( 0 + ( i * 3 + 1 ) );
                Items[ i ].SetsRequired = parser.ReadColumn< ushort >( 0 + ( i * 3 + 2 ) );
            }
        }
    }
}