using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GimmickAccessor", columnHash: 0xc4f527f3 )]
    public class GimmickAccessor : IExcelRow
    {
        
        public int Param0;
        public uint Param1;
        public uint Param2;
        public uint Type;
        public uint Unknown4;
        public uint Unknown5;
        public uint Unknown6;
        public bool Unknown7;
        public bool Unknown8;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Param0 = parser.ReadColumn< int >( 0 );
            Param1 = parser.ReadColumn< uint >( 1 );
            Param2 = parser.ReadColumn< uint >( 2 );
            Type = parser.ReadColumn< uint >( 3 );
            Unknown4 = parser.ReadColumn< uint >( 4 );
            Unknown5 = parser.ReadColumn< uint >( 5 );
            Unknown6 = parser.ReadColumn< uint >( 6 );
            Unknown7 = parser.ReadColumn< bool >( 7 );
            Unknown8 = parser.ReadColumn< bool >( 8 );
        }
    }
}