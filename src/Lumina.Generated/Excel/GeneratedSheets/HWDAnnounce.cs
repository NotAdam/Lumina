using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HWDAnnounce", columnHash: 0x1d91a784 )]
    public class HWDAnnounce : IExcelRow
    {
        
        public string Name;
        public LazyRow< ENpcResident > ENPC;
        public byte Unknown2;
        public byte Unknown3;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Name = parser.ReadColumn< string >( 0 );
            ENPC = new LazyRow< ENpcResident >( lumina, parser.ReadColumn< uint >( 1 ), language );
            Unknown2 = parser.ReadColumn< byte >( 2 );
            Unknown3 = parser.ReadColumn< byte >( 3 );
        }
    }
}