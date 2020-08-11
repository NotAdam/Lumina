// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CompanyCraftDraft", columnHash: 0xdf938294 )]
    public class CompanyCraftDraft : IExcelRow
    {
        public struct UnkStruct2Struct
        {
            public int RequiredItem;
            public byte RequiredItemCount;
        }
        
        public string Name;
        public LazyRow< CompanyCraftDraftCategory > CompanyCraftDraftCategory;
        public UnkStruct2Struct[] UnkStruct2;
        public uint Order;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Name = parser.ReadColumn< string >( 0 );
            CompanyCraftDraftCategory = new LazyRow< CompanyCraftDraftCategory >( lumina, parser.ReadColumn< byte >( 1 ), language );
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