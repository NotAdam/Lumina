using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ScreenImage", columnHash: 0xf03c70eb )]
    public class ScreenImage : IExcelRow
    {
        
        public uint Image;
        public short Jingle;
        public sbyte Type;
        public bool Lang;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Image = parser.ReadColumn< uint >( 0 );
            Jingle = parser.ReadColumn< short >( 1 );
            Type = parser.ReadColumn< sbyte >( 2 );
            Lang = parser.ReadColumn< bool >( 3 );
        }
    }
}