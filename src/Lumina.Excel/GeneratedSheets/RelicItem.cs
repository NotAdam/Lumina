// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "RelicItem", columnHash: 0xc8fc45d9 )]
    public class RelicItem : ExcelRow
    {
        
        public byte Unknown0;
        public LazyRow< Item > GladiatorItem;
        public LazyRow< Item > PugilistItem;
        public LazyRow< Item > MarauderItem;
        public LazyRow< Item > LancerItem;
        public LazyRow< Item > ArcherItem;
        public LazyRow< Item > ConjurerItem;
        public LazyRow< Item > ThaumaturgeItem;
        public LazyRow< Item > ArcanistSMNItem;
        public LazyRow< Item > ArcanistSCHItem;
        public LazyRow< Item > ShieldItem;
        public LazyRow< Item > RogueItem;
        public uint Unknown12;
        public uint Unknown13;
        public uint Unknown14;
        public uint Unknown15;
        public uint Unknown16;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Unknown0 = parser.ReadColumn< byte >( 0 );
            GladiatorItem = new LazyRow< Item >( lumina, parser.ReadColumn< uint >( 1 ), language );
            PugilistItem = new LazyRow< Item >( lumina, parser.ReadColumn< uint >( 2 ), language );
            MarauderItem = new LazyRow< Item >( lumina, parser.ReadColumn< uint >( 3 ), language );
            LancerItem = new LazyRow< Item >( lumina, parser.ReadColumn< uint >( 4 ), language );
            ArcherItem = new LazyRow< Item >( lumina, parser.ReadColumn< uint >( 5 ), language );
            ConjurerItem = new LazyRow< Item >( lumina, parser.ReadColumn< uint >( 6 ), language );
            ThaumaturgeItem = new LazyRow< Item >( lumina, parser.ReadColumn< uint >( 7 ), language );
            ArcanistSMNItem = new LazyRow< Item >( lumina, parser.ReadColumn< uint >( 8 ), language );
            ArcanistSCHItem = new LazyRow< Item >( lumina, parser.ReadColumn< uint >( 9 ), language );
            ShieldItem = new LazyRow< Item >( lumina, parser.ReadColumn< uint >( 10 ), language );
            RogueItem = new LazyRow< Item >( lumina, parser.ReadColumn< uint >( 11 ), language );
            Unknown12 = parser.ReadColumn< uint >( 12 );
            Unknown13 = parser.ReadColumn< uint >( 13 );
            Unknown14 = parser.ReadColumn< uint >( 14 );
            Unknown15 = parser.ReadColumn< uint >( 15 );
            Unknown16 = parser.ReadColumn< uint >( 16 );
        }
    }
}