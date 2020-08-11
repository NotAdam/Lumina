// ReSharper disable All

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
        public string SoundEffect4;
        public string SoundEffect3;
        public string SoundEffect2;
        public string SoundEffect1;
        
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
            SoundEffect4 = parser.ReadColumn< string >( 4 );
            SoundEffect3 = parser.ReadColumn< string >( 5 );
            SoundEffect2 = parser.ReadColumn< string >( 6 );
            SoundEffect1 = parser.ReadColumn< string >( 7 );
        }
    }
}