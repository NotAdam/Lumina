// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "RelicItem", columnHash: 0xc8fc45d9 )]
    public partial class RelicItem : ExcelRow
    {
        
        public byte Unknown0 { get; set; }
        public LazyRow< Item > GladiatorItem { get; set; }
        public LazyRow< Item > PugilistItem { get; set; }
        public LazyRow< Item > MarauderItem { get; set; }
        public LazyRow< Item > LancerItem { get; set; }
        public LazyRow< Item > ArcherItem { get; set; }
        public LazyRow< Item > ConjurerItem { get; set; }
        public LazyRow< Item > ThaumaturgeItem { get; set; }
        public LazyRow< Item > ArcanistSMNItem { get; set; }
        public LazyRow< Item > ArcanistSCHItem { get; set; }
        public LazyRow< Item > ShieldItem { get; set; }
        public LazyRow< Item > RogueItem { get; set; }
        public uint Unknown12 { get; set; }
        public uint Unknown13 { get; set; }
        public uint Unknown14 { get; set; }
        public uint Unknown15 { get; set; }
        public uint Unknown16 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< byte >( 0 );
            GladiatorItem = new LazyRow< Item >( gameData, parser.ReadColumn< uint >( 1 ), language );
            PugilistItem = new LazyRow< Item >( gameData, parser.ReadColumn< uint >( 2 ), language );
            MarauderItem = new LazyRow< Item >( gameData, parser.ReadColumn< uint >( 3 ), language );
            LancerItem = new LazyRow< Item >( gameData, parser.ReadColumn< uint >( 4 ), language );
            ArcherItem = new LazyRow< Item >( gameData, parser.ReadColumn< uint >( 5 ), language );
            ConjurerItem = new LazyRow< Item >( gameData, parser.ReadColumn< uint >( 6 ), language );
            ThaumaturgeItem = new LazyRow< Item >( gameData, parser.ReadColumn< uint >( 7 ), language );
            ArcanistSMNItem = new LazyRow< Item >( gameData, parser.ReadColumn< uint >( 8 ), language );
            ArcanistSCHItem = new LazyRow< Item >( gameData, parser.ReadColumn< uint >( 9 ), language );
            ShieldItem = new LazyRow< Item >( gameData, parser.ReadColumn< uint >( 10 ), language );
            RogueItem = new LazyRow< Item >( gameData, parser.ReadColumn< uint >( 11 ), language );
            Unknown12 = parser.ReadColumn< uint >( 12 );
            Unknown13 = parser.ReadColumn< uint >( 13 );
            Unknown14 = parser.ReadColumn< uint >( 14 );
            Unknown15 = parser.ReadColumn< uint >( 15 );
            Unknown16 = parser.ReadColumn< uint >( 16 );
        }
    }
}