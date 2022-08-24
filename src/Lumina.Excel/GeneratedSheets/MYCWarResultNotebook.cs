// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MYCWarResultNotebook", columnHash: 0x02f3734a )]
    public partial class MYCWarResultNotebook : ExcelRow
    {
        
        public byte Number { get; set; }
        public byte Unknown1 { get; set; }
        public byte Link { get; set; }
        public LazyRow< Quest > Quest { get; set; }
        public int Unknown4 { get; set; }
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
            Unknown1 = parser.ReadColumn< byte >( 1 );
            Link = parser.ReadColumn< byte >( 2 );
            Quest = new LazyRow< Quest >( gameData, parser.ReadColumn< int >( 3 ), language );
            Unknown4 = parser.ReadColumn< int >( 4 );
            Icon = parser.ReadColumn< int >( 5 );
            Image = parser.ReadColumn< int >( 6 );
            Rarity = parser.ReadColumn< byte >( 7 );
            NameJP = parser.ReadColumn< SeString >( 8 );
            Name = parser.ReadColumn< SeString >( 9 );
            Description = parser.ReadColumn< SeString >( 10 );
        }
    }
}