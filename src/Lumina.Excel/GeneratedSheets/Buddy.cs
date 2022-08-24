// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Buddy", columnHash: 0xd2892cc5 )]
    public partial class Buddy : ExcelRow
    {
        
        public byte Base { get; set; }
        public LazyRow< Quest > QuestRequirement2 { get; set; }
        public LazyRow< Quest > QuestRequirement1 { get; set; }
        public int BaseEquip { get; set; }
        public SeString SoundEffect4 { get; set; }
        public SeString SoundEffect3 { get; set; }
        public SeString SoundEffect2 { get; set; }
        public SeString SoundEffect1 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Base = parser.ReadColumn< byte >( 0 );
            QuestRequirement2 = new LazyRow< Quest >( gameData, parser.ReadColumn< int >( 1 ), language );
            QuestRequirement1 = new LazyRow< Quest >( gameData, parser.ReadColumn< int >( 2 ), language );
            BaseEquip = parser.ReadColumn< int >( 3 );
            SoundEffect4 = parser.ReadColumn< SeString >( 4 );
            SoundEffect3 = parser.ReadColumn< SeString >( 5 );
            SoundEffect2 = parser.ReadColumn< SeString >( 6 );
            SoundEffect1 = parser.ReadColumn< SeString >( 7 );
        }
    }
}