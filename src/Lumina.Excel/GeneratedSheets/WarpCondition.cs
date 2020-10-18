// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "WarpCondition", columnHash: 0xc096f9d0 )]
    public class WarpCondition : IExcelRow
    {
        
        public ushort Gil;
        public byte CompleteParam;
        public LazyRow< Quest > RequiredQuest1;
        public LazyRow< Quest > RequiredQuest2;
        public LazyRow< Quest > DRequiredQuest3;
        public LazyRow< Quest > RequiredQuest4;
        public ushort QuestReward;
        public ushort ClassLevel;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Gil = parser.ReadColumn< ushort >( 0 );
            CompleteParam = parser.ReadColumn< byte >( 1 );
            RequiredQuest1 = new LazyRow< Quest >( lumina, parser.ReadColumn< uint >( 2 ), language );
            RequiredQuest2 = new LazyRow< Quest >( lumina, parser.ReadColumn< uint >( 3 ), language );
            DRequiredQuest3 = new LazyRow< Quest >( lumina, parser.ReadColumn< uint >( 4 ), language );
            RequiredQuest4 = new LazyRow< Quest >( lumina, parser.ReadColumn< uint >( 5 ), language );
            QuestReward = parser.ReadColumn< ushort >( 6 );
            ClassLevel = parser.ReadColumn< ushort >( 7 );
        }
    }
}