// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MYCWarResultNotebook", columnHash: 0x446c84d6 )]
    public class MYCWarResultNotebook : ExcelRow
    {
        
        public byte Number;
        public byte Unknown540;
        public byte Unknown541;
        public LazyRow< Quest > Quest;
        public int Icon;
        public int Image;
        public byte Rarity;
        public SeString NameJP;
        public SeString Name;
        public SeString Description;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Number = parser.ReadColumn< byte >( 0 );
            Unknown540 = parser.ReadColumn< byte >( 1 );
            Unknown541 = parser.ReadColumn< byte >( 2 );
            Quest = new LazyRow< Quest >( lumina, parser.ReadColumn< int >( 3 ), language );
            Icon = parser.ReadColumn< int >( 4 );
            Image = parser.ReadColumn< int >( 5 );
            Rarity = parser.ReadColumn< byte >( 6 );
            NameJP = parser.ReadColumn< SeString >( 7 );
            Name = parser.ReadColumn< SeString >( 8 );
            Description = parser.ReadColumn< SeString >( 9 );
        }
    }
}