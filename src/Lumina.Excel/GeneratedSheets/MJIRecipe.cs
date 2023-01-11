// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MJIRecipe", columnHash: 0xcfeffbad )]
    public partial class MJIRecipe : ExcelRow
    {
        public class MJIRecipeUnkData4Obj
        {
            public byte Material { get; set; }
            public byte Amount { get; set; }
        }
        
        public LazyRow< LogMessage > LogMessage { get; set; }
        public LazyRow< MJIKeyItem > KeyItem { get; set; }
        public LazyRow< MJIItemPouch > ItemPouch { get; set; }
        public byte Unknown3 { get; set; }
        public MJIRecipeUnkData4Obj[] UnkData4 { get; set; }
        public byte Order { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            LogMessage = new LazyRow< LogMessage >( gameData, parser.ReadColumn< uint >( 0 ), language );
            KeyItem = new LazyRow< MJIKeyItem >( gameData, parser.ReadColumn< byte >( 1 ), language );
            ItemPouch = new LazyRow< MJIItemPouch >( gameData, parser.ReadColumn< byte >( 2 ), language );
            Unknown3 = parser.ReadColumn< byte >( 3 );
            UnkData4 = new MJIRecipeUnkData4Obj[ 5 ];
            for( var i = 0; i < 5; i++ )
            {
                UnkData4[ i ] = new MJIRecipeUnkData4Obj();
                UnkData4[ i ].Material = parser.ReadColumn< byte >( 4 + ( i * 2 + 0 ) );
                UnkData4[ i ].Amount = parser.ReadColumn< byte >( 4 + ( i * 2 + 1 ) );
            }
            Order = parser.ReadColumn< byte >( 14 );
        }
    }
}