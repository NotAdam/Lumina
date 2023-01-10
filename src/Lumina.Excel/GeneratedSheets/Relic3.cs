// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Relic3", columnHash: 0xeb3c566a )]
    public partial class Relic3 : ExcelRow
    {
        
        public LazyRow< Item > ItemAnimus { get; set; }
        public LazyRow< Item > ItemScroll { get; set; }
        public byte MateriaLimit { get; set; }
        public LazyRow< Item > ItemNovus { get; set; }
        public int Icon { get; set; }
        public sbyte Unknown5 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            ItemAnimus = new LazyRow< Item >( gameData, parser.ReadColumn< uint >( 0 ), language );
            ItemScroll = new LazyRow< Item >( gameData, parser.ReadColumn< uint >( 1 ), language );
            MateriaLimit = parser.ReadColumn< byte >( 2 );
            ItemNovus = new LazyRow< Item >( gameData, parser.ReadColumn< uint >( 3 ), language );
            Icon = parser.ReadColumn< int >( 4 );
            Unknown5 = parser.ReadColumn< sbyte >( 5 );
        }
    }
}