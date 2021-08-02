// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ItemFood", columnHash: 0xe09a474d )]
    public class ItemFood : ExcelRow
    {
        public class ItemBuffInfo
        {
            public byte BaseParam { get; set; }
            public bool IsRelative { get; set; }
            public sbyte Value { get; set; }
            public short Max { get; set; }
            public sbyte ValueHQ { get; set; }
            public short MaxHQ { get; set; }
        }
        
        public byte EXPBonusPct { get; set; }
        public ItemBuffInfo[] BuffInfo { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            EXPBonusPct = parser.ReadColumn< byte >( 0 );
            BuffInfo = new ItemBuffInfo[ 3 ];
            for( var i = 0; i < 3; i++ )
            {
                BuffInfo[ i ] = new ItemBuffInfo();
                BuffInfo[ i ].BaseParam = parser.ReadColumn< byte >( 1 + ( i * 6 + 0 ) );
                BuffInfo[ i ].IsRelative = parser.ReadColumn< bool >( 1 + ( i * 6 + 1 ) );
                BuffInfo[ i ].Value = parser.ReadColumn< sbyte >( 1 + ( i * 6 + 2 ) );
                BuffInfo[ i ].Max = parser.ReadColumn< short >( 1 + ( i * 6 + 3 ) );
                BuffInfo[ i ].ValueHQ = parser.ReadColumn< sbyte >( 1 + ( i * 6 + 4 ) );
                BuffInfo[ i ].MaxHQ = parser.ReadColumn< short >( 1 + ( i * 6 + 5 ) );
            }
        }
    }
}