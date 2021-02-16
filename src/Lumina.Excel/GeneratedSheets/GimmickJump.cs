// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GimmickJump", columnHash: 0x4858f2f1 )]
    public class GimmickJump : ExcelRow
    {
        
        public ushort FallDamage;
        public sbyte Height;
        public LazyRow< ActionTimeline > LoopMotion;
        public LazyRow< ActionTimeline > EndMotion;
        public bool StartClient;
        public bool Unknown5;
        

        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            FallDamage = parser.ReadColumn< ushort >( 0 );
            Height = parser.ReadColumn< sbyte >( 1 );
            LoopMotion = new LazyRow< ActionTimeline >( gameData, parser.ReadColumn< uint >( 2 ), language );
            EndMotion = new LazyRow< ActionTimeline >( gameData, parser.ReadColumn< uint >( 3 ), language );
            StartClient = parser.ReadColumn< bool >( 4 );
            Unknown5 = parser.ReadColumn< bool >( 5 );
        }
    }
}