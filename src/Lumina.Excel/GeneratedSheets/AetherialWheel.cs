// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "AetherialWheel", columnHash: 0xfee5acb6 )]
    public partial class AetherialWheel : ExcelRow
    {
        
        public LazyRow< Item > ItemUnprimed { get; set; }
        public LazyRow< Item > ItemPrimed { get; set; }
        public byte Grade { get; set; }
        public byte HoursRequired { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            ItemUnprimed = new LazyRow< Item >( gameData, parser.ReadColumn< int >( 0 ), language );
            ItemPrimed = new LazyRow< Item >( gameData, parser.ReadColumn< int >( 1 ), language );
            Grade = parser.ReadColumn< byte >( 2 );
            HoursRequired = parser.ReadColumn< byte >( 3 );
        }
    }
}