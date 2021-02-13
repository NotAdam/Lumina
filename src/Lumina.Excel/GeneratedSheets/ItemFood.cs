// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ItemFood", columnHash: 0xe09a474d )]
    public class ItemFood : ExcelRow
    {
        public struct UnkStruct1Struct
        {
            public byte BaseParam;
            public bool IsRelative;
            public sbyte Value;
            public short Max;
            public sbyte ValueHQ;
            public short MaxHQ;
        }
        
        public byte EXPBonusPct;
        public UnkStruct1Struct[] UnkStruct1;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            EXPBonusPct = parser.ReadColumn< byte >( 0 );
            UnkStruct1 = new UnkStruct1Struct[ 3 ];
            for( var i = 0; i < 3; i++ )
            {
                UnkStruct1[ i ] = new UnkStruct1Struct();
                UnkStruct1[ i ].BaseParam = parser.ReadColumn< byte >( 1 + ( i * 6 + 0 ) );
                UnkStruct1[ i ].IsRelative = parser.ReadColumn< bool >( 1 + ( i * 6 + 1 ) );
                UnkStruct1[ i ].Value = parser.ReadColumn< sbyte >( 1 + ( i * 6 + 2 ) );
                UnkStruct1[ i ].Max = parser.ReadColumn< short >( 1 + ( i * 6 + 3 ) );
                UnkStruct1[ i ].ValueHQ = parser.ReadColumn< sbyte >( 1 + ( i * 6 + 4 ) );
                UnkStruct1[ i ].MaxHQ = parser.ReadColumn< short >( 1 + ( i * 6 + 5 ) );
            }
        }
    }
}