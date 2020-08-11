// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ScenarioTreeTipsClassQuest", columnHash: 0xae1d30a7 )]
    public class ScenarioTreeTipsClassQuest : IExcelRow
    {
        
        public LazyRow< Quest > Quest;
        public ushort RequiredLevel;
        public LazyRow< ExVersion > RequiredExpansion;
        public LazyRow< Quest > RequiredQuest;
        public bool Unknown4;
        public bool Unknown5;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Quest = new LazyRow< Quest >( lumina, parser.ReadColumn< uint >( 0 ), language );
            RequiredLevel = parser.ReadColumn< ushort >( 1 );
            RequiredExpansion = new LazyRow< ExVersion >( lumina, parser.ReadColumn< byte >( 2 ), language );
            RequiredQuest = new LazyRow< Quest >( lumina, parser.ReadColumn< uint >( 3 ), language );
            Unknown4 = parser.ReadColumn< bool >( 4 );
            Unknown5 = parser.ReadColumn< bool >( 5 );
        }
    }
}