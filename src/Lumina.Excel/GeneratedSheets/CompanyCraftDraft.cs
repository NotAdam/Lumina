// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CompanyCraftDraft", columnHash: 0xdf938294 )]
    public class CompanyCraftDraft : ExcelRow
    {
        public struct UnkStruct2Struct
        {
            public int RequiredItem;
            public byte RequiredItemCount;
        }
        
        public SeString Name { get; set; }
        public LazyRow< CompanyCraftDraftCategory > CompanyCraftDraftCategory { get; set; }
        public UnkStruct2Struct[] UnkStruct2 { get; set; }
        public uint Order { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Name = parser.ReadColumn< SeString >( 0 );
            CompanyCraftDraftCategory = new LazyRow< CompanyCraftDraftCategory >( gameData, parser.ReadColumn< byte >( 1 ), language );
            UnkStruct2 = new UnkStruct2Struct[ 3 ];
            for( var i = 0; i < 3; i++ )
            {
                UnkStruct2[ i ] = new UnkStruct2Struct();
                UnkStruct2[ i ].RequiredItem = parser.ReadColumn< int >( 2 + ( i * 2 + 0 ) );
                UnkStruct2[ i ].RequiredItemCount = parser.ReadColumn< byte >( 2 + ( i * 2 + 1 ) );
            }
            Order = parser.ReadColumn< uint >( 8 );
        }
    }
}