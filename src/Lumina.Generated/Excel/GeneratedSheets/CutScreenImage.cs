using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CutScreenImage", columnHash: 0xe4a523cd )]
    public class CutScreenImage : IExcelRow
    {
        
        public short Type;
        public int Image;
        public short Unknown2;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Type = parser.ReadColumn< short >( 0 );
            Image = parser.ReadColumn< int >( 1 );
            Unknown2 = parser.ReadColumn< short >( 2 );
        }
    }
}