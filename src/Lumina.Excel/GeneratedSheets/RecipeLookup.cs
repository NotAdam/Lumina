// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "RecipeLookup", columnHash: 0xa708a4a0 )]
    public partial class RecipeLookup : ExcelRow
    {
        
        public LazyRow< Recipe > CRP { get; set; }
        public LazyRow< Recipe > BSM { get; set; }
        public LazyRow< Recipe > ARM { get; set; }
        public LazyRow< Recipe > GSM { get; set; }
        public LazyRow< Recipe > LTW { get; set; }
        public LazyRow< Recipe > WVR { get; set; }
        public LazyRow< Recipe > ALC { get; set; }
        public LazyRow< Recipe > CUL { get; set; }
        
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