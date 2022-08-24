// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ItemSortCategory", columnHash: 0xdcfd9eba )]
    public partial class ItemSortCategory : ExcelRow
    {
        
        public byte Param { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Param = parser.ReadColumn< byte >( 0 );
        }
    }
}