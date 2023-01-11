// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MJIStockyardManagementTable", columnHash: 0xdcfd9eba )]
    public partial class MJIStockyardManagementTable : ExcelRow
    {
        
        public LazyRow< MJIItemPouch > Material { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Material = new LazyRow< MJIItemPouch >( gameData, parser.ReadColumn< byte >( 0 ), language );
        }
    }
}