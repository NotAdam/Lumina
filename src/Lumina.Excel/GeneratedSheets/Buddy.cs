// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Buddy", columnHash: 0xd2892cc5 )]
    public class Buddy : IExcelRow
    {
        
        public byte Base;
        public LazyRow< Quest > QuestRequirement2;
        public LazyRow< Quest > QuestRequirement1;
        public int BaseEquip;
        public SeString SoundEffect4;
        public SeString SoundEffect3;
        public SeString SoundEffect2;
        public SeString SoundEffect1;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Base = parser.ReadColumn< byte >( 0 );
            QuestRequirement2 = new LazyRow< Quest >( lumina, parser.ReadColumn< int >( 1 ), language );
            QuestRequirement1 = new LazyRow< Quest >( lumina, parser.ReadColumn< int >( 2 ), language );
            BaseEquip = parser.ReadColumn< int >( 3 );
            SoundEffect4 = parser.ReadColumn< SeString >( 4 );
            SoundEffect3 = parser.ReadColumn< SeString >( 5 );
            SoundEffect2 = parser.ReadColumn< SeString >( 6 );
            SoundEffect1 = parser.ReadColumn< SeString >( 7 );
        }
    }
}