using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CompanyCraftDraftCategory", columnHash: 0xf6570594 )]
    public class CompanyCraftDraftCategory : IExcelRow
    {
        public struct UnkStruct1Struct
        {
            public ushort CompanyCraftType;
        }
        
        public string Name;
        public UnkStruct1Struct[] UnkStruct1;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Name = parser.ReadColumn< string >( 0 );
            UnkStruct1 = new UnkStruct1Struct[ 10 ];
            for( var i = 0; i < 10; i++ )
            {
                UnkStruct1[ i ] = new UnkStruct1Struct();
                UnkStruct1[ i ].CompanyCraftType = parser.ReadColumn< ushort >( 1 + ( i * 1 + 0 ) );
            }
        }
    }
}