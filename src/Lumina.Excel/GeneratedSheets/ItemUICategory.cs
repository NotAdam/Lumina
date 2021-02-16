// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ItemUICategory", columnHash: 0xdc1f7844 )]
    public class ItemUICategory : ExcelRow
    {
        
        public SeString Name;
        public int Icon;
        public byte OrderMinor;
        public byte OrderMajor;
        

        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Name = parser.ReadColumn< SeString >( 0 );
            Icon = parser.ReadColumn< int >( 1 );
            OrderMinor = parser.ReadColumn< byte >( 2 );
            OrderMajor = parser.ReadColumn< byte >( 3 );
        }
    }
}