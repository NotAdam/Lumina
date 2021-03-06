// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MYCWarResultNotebook", columnHash: 0x446c84d6 )]
    public class MYCWarResultNotebook : ExcelRow
    {
        
        public byte Number { get; set; }
        public byte Unknown540 { get; set; }
        public byte Unknown541 { get; set; }
        public LazyRow< Quest > Quest { get; set; }
        public int Icon { get; set; }
        public int Image { get; set; }
        public byte Rarity { get; set; }
        public SeString NameJP { get; set; }
        public SeString Name { get; set; }
        public SeString Description { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Number = parser.ReadColumn< byte >( 0 );
            Unknown540 = parser.ReadColumn< byte >( 1 );
            Unknown541 = parser.ReadColumn< byte >( 2 );
            Quest = new LazyRow< Quest >( gameData, parser.ReadColumn< int >( 3 ), language );
            Icon = parser.ReadColumn< int >( 4 );
            Image = parser.ReadColumn< int >( 5 );
            Rarity = parser.ReadColumn< byte >( 6 );
            NameJP = parser.ReadColumn< SeString >( 7 );
            Name = parser.ReadColumn< SeString >( 8 );
            Description = parser.ReadColumn< SeString >( 9 );
        }
    }
}