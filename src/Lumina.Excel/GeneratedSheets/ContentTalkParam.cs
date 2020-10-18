// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ContentTalkParam", columnHash: 0xd4cefacf )]
    public class ContentTalkParam : IExcelRow
    {
        
        public bool Param;
        public byte Unknown1;
        public LazyRow< ActionTimeline > TestAction;
        public sbyte Unknown3;
        public sbyte Unknown4;
        public byte Unknown5;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Param = parser.ReadColumn< bool >( 0 );
            Unknown1 = parser.ReadColumn< byte >( 1 );
            TestAction = new LazyRow< ActionTimeline >( lumina, parser.ReadColumn< uint >( 2 ), language );
            Unknown3 = parser.ReadColumn< sbyte >( 3 );
            Unknown4 = parser.ReadColumn< sbyte >( 4 );
            Unknown5 = parser.ReadColumn< byte >( 5 );
        }
    }
}