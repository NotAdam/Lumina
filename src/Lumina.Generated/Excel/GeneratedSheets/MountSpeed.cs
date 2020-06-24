using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MountSpeed", columnHash: 0x91ab8236 )]
    public class MountSpeed : IExcelRow
    {
        
        public LazyRow< Quest > Quest;
        public uint Unknown1;
        public byte Unknown2;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Quest = new LazyRow< Quest >( lumina, parser.ReadColumn< uint >( 0 ), language );
            Unknown1 = parser.ReadColumn< uint >( 1 );
            Unknown2 = parser.ReadColumn< byte >( 2 );
        }
    }
}