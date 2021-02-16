// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CompanyCraftDraftCategory", columnHash: 0xf6570594 )]
    public class CompanyCraftDraftCategory : ExcelRow
    {
        public struct UnkStruct1Struct
        {
            public ushort CompanyCraftType;
        }
        
        public SeString Name;
        public UnkStruct1Struct[] UnkStruct1;
        

        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Name = parser.ReadColumn< SeString >( 0 );
            UnkStruct1 = new UnkStruct1Struct[ 10 ];
            for( var i = 0; i < 10; i++ )
            {
                UnkStruct1[ i ] = new UnkStruct1Struct();
                UnkStruct1[ i ].CompanyCraftType = parser.ReadColumn< ushort >( 1 + ( i * 1 + 0 ) );
            }
        }
    }
}