// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ItemFood", columnHash: 0xe09a474d )]
    public partial class ItemFood : ExcelRow
    {
        public class ItemFoodUnkData1Obj
        {
            public byte BaseParam { get; set; }
            public bool IsRelative { get; set; }
            public sbyte Value { get; set; }
            public short Max { get; set; }
            public sbyte ValueHQ { get; set; }
            public short MaxHQ { get; set; }
        }
        
        public byte EXPBonusPct { get; set; }
        public ItemFoodUnkData1Obj[] UnkData1 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            EXPBonusPct = parser.ReadColumn< byte >( 0 );
            UnkData1 = new ItemFoodUnkData1Obj[ 3 ];
            for( var i = 0; i < 3; i++ )
            {
                UnkData1[ i ] = new ItemFoodUnkData1Obj();
                UnkData1[ i ].BaseParam = parser.ReadColumn< byte >( 1 + ( i * 6 + 0 ) );
                UnkData1[ i ].IsRelative = parser.ReadColumn< bool >( 1 + ( i * 6 + 1 ) );
                UnkData1[ i ].Value = parser.ReadColumn< sbyte >( 1 + ( i * 6 + 2 ) );
                UnkData1[ i ].Max = parser.ReadColumn< short >( 1 + ( i * 6 + 3 ) );
                UnkData1[ i ].ValueHQ = parser.ReadColumn< sbyte >( 1 + ( i * 6 + 4 ) );
                UnkData1[ i ].MaxHQ = parser.ReadColumn< short >( 1 + ( i * 6 + 5 ) );
            }
        }
    }
}