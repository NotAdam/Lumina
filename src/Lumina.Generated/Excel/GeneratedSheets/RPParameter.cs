// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "RPParameter", columnHash: 0x251a33cc )]
    public class RPParameter : IExcelRow
    {
        
        public LazyRow< BNpcName > BNpcName;
        public LazyRow< ClassJob > ClassJob;
        public byte Unknown2;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            BNpcName = new LazyRow< BNpcName >( lumina, parser.ReadColumn< ushort >( 0 ), language );
            ClassJob = new LazyRow< ClassJob >( lumina, parser.ReadColumn< byte >( 1 ), language );
            Unknown2 = parser.ReadColumn< byte >( 2 );
        }
    }
}