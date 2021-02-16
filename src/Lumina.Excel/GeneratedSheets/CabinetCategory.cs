// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CabinetCategory", columnHash: 0xc6207018 )]
    public class CabinetCategory : ExcelRow
    {
        
        public byte MenuOrder;
        public int Icon;
        public LazyRow< Addon > Category;
        

        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            MenuOrder = parser.ReadColumn< byte >( 0 );
            Icon = parser.ReadColumn< int >( 1 );
            Category = new LazyRow< Addon >( gameData, parser.ReadColumn< int >( 2 ), language );
        }
    }
}