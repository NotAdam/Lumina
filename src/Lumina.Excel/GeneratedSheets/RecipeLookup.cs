// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "RecipeLookup", columnHash: 0xa708a4a0 )]
    public class RecipeLookup : ExcelRow
    {
        
        public LazyRow< Recipe > CRP;
        public LazyRow< Recipe > BSM;
        public LazyRow< Recipe > ARM;
        public LazyRow< Recipe > GSM;
        public LazyRow< Recipe > LTW;
        public LazyRow< Recipe > WVR;
        public LazyRow< Recipe > ALC;
        public LazyRow< Recipe > CUL;
        

        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            CRP = new LazyRow< Recipe >( gameData, parser.ReadColumn< ushort >( 0 ), language );
            BSM = new LazyRow< Recipe >( gameData, parser.ReadColumn< ushort >( 1 ), language );
            ARM = new LazyRow< Recipe >( gameData, parser.ReadColumn< ushort >( 2 ), language );
            GSM = new LazyRow< Recipe >( gameData, parser.ReadColumn< ushort >( 3 ), language );
            LTW = new LazyRow< Recipe >( gameData, parser.ReadColumn< ushort >( 4 ), language );
            WVR = new LazyRow< Recipe >( gameData, parser.ReadColumn< ushort >( 5 ), language );
            ALC = new LazyRow< Recipe >( gameData, parser.ReadColumn< ushort >( 6 ), language );
            CUL = new LazyRow< Recipe >( gameData, parser.ReadColumn< ushort >( 7 ), language );
        }
    }
}