// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CompanyCraftProcess", columnHash: 0x3135b48e )]
    public class CompanyCraftProcess : ExcelRow
    {
        public struct UnkStruct0Struct
        {
            public ushort SupplyItem;
            public ushort SetQuantity;
            public ushort SetsRequired;
        }
        
        public UnkStruct0Struct[] UnkStruct0 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            UnkStruct0 = new UnkStruct0Struct[ 12 ];
            for( var i = 0; i < 12; i++ )
            {
                UnkStruct0[ i ] = new UnkStruct0Struct();
                UnkStruct0[ i ].SupplyItem = parser.ReadColumn< ushort >( 0 + ( i * 3 + 0 ) );
                UnkStruct0[ i ].SetQuantity = parser.ReadColumn< ushort >( 0 + ( i * 3 + 1 ) );
                UnkStruct0[ i ].SetsRequired = parser.ReadColumn< ushort >( 0 + ( i * 3 + 2 ) );
            }
        }
    }
}