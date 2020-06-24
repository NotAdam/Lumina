using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GimmickJump", columnHash: 0x4858f2f1 )]
    public class GimmickJump : IExcelRow
    {
        
        public ushort FallDamage;
        public sbyte Height;
        public LazyRow< MotionTimeline > LoopMotion;
        public LazyRow< MotionTimeline > EndMotion;
        public bool StartClient;
        public bool Unknown5;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            FallDamage = parser.ReadColumn< ushort >( 0 );
            Height = parser.ReadColumn< sbyte >( 1 );
            LoopMotion = new LazyRow< MotionTimeline >( lumina, parser.ReadColumn< uint >( 2 ), language );
            EndMotion = new LazyRow< MotionTimeline >( lumina, parser.ReadColumn< uint >( 3 ), language );
            StartClient = parser.ReadColumn< bool >( 4 );
            Unknown5 = parser.ReadColumn< bool >( 5 );
        }
    }
}