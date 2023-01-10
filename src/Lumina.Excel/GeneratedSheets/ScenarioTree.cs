// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ScenarioTree", columnHash: 0xca183be8 )]
    public partial class ScenarioTree : ExcelRow
    {
        
        public LazyRow< ScenarioType > Type { get; set; }
        public ushort Unknown1 { get; set; }
        public LazyRow< Addon > Addon { get; set; }
        public LazyRow< QuestChapter > QuestChapter { get; set; }
        public SeString Name { get; set; }
        public int Unknown5 { get; set; }
        public uint Unknown6 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Type = new LazyRow< ScenarioType >( gameData, parser.ReadColumn< byte >( 0 ), language );
            Unknown1 = parser.ReadColumn< ushort >( 1 );
            Addon = new LazyRow< Addon >( gameData, parser.ReadColumn< uint >( 2 ), language );
            QuestChapter = new LazyRow< QuestChapter >( gameData, parser.ReadColumn< uint >( 3 ), language );
            Name = parser.ReadColumn< SeString >( 4 );
            Unknown5 = parser.ReadColumn< int >( 5 );
            Unknown6 = parser.ReadColumn< uint >( 6 );
        }
    }
}