// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "FieldMarker", columnHash: 0x23003392 )]
    public class FieldMarker : IExcelRow
    {
        
        public LazyRow< VFX > VFX;
        public ushort Icon;
        public ushort Unknown2;
        public string Unknown3;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            VFX = new LazyRow< VFX >( lumina, parser.ReadColumn< int >( 0 ), language );
            Icon = parser.ReadColumn< ushort >( 1 );
            Unknown2 = parser.ReadColumn< ushort >( 2 );
            Unknown3 = parser.ReadColumn< string >( 3 );
        }
    }
}