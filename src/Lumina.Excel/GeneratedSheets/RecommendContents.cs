// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "RecommendContents", columnHash: 0xe79dd9d4 )]
    public class RecommendContents : ExcelRow
    {
        
        public LazyRow< Level > Level;
        public LazyRow< ClassJob > ClassJob;
        public byte MinLevel;
        public byte MaxLevel;
        

        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Level = new LazyRow< Level >( gameData, parser.ReadColumn< int >( 0 ), language );
            ClassJob = new LazyRow< ClassJob >( gameData, parser.ReadColumn< byte >( 1 ), language );
            MinLevel = parser.ReadColumn< byte >( 2 );
            MaxLevel = parser.ReadColumn< byte >( 3 );
        }
    }
}