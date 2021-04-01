// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "JournalCategory", columnHash: 0xc5670d26 )]
    public class JournalCategory : ExcelRow
    {
        
        public SeString Name { get; set; }
        public byte SeparateType { get; set; }
        public byte DataType { get; set; }
        public LazyRow< JournalSection > JournalSection { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Name = parser.ReadColumn< SeString >( 0 );
            SeparateType = parser.ReadColumn< byte >( 1 );
            DataType = parser.ReadColumn< byte >( 2 );
            JournalSection = new LazyRow< JournalSection >( gameData, parser.ReadColumn< byte >( 3 ), language );
        }
    }
}