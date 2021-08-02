// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CompanyCraftProcess", columnHash: 0x3135b48e )]
    public partial class CompanyCraftProcess : ExcelRow
    {
        public class CompanyCraftProcessUnkData0Obj
        {
            public ushort SupplyItem { get; set; }
            public ushort SetQuantity { get; set; }
            public ushort SetsRequired { get; set; }
        }
        
        public CompanyCraftProcessUnkData0Obj[] UnkData0 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            UnkData0 = new CompanyCraftProcessUnkData0Obj[ 12 ];
            for( var i = 0; i < 12; i++ )
            {
                UnkData0[ i ] = new CompanyCraftProcessUnkData0Obj();
                UnkData0[ i ].SupplyItem = parser.ReadColumn< ushort >( 0 + ( i * 3 + 0 ) );
                UnkData0[ i ].SetQuantity = parser.ReadColumn< ushort >( 0 + ( i * 3 + 1 ) );
                UnkData0[ i ].SetsRequired = parser.ReadColumn< ushort >( 0 + ( i * 3 + 2 ) );
            }
        }
    }
}