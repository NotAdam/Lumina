// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MJIStockyardManagementArea", columnHash: 0x43bdd5b1 )]
    public partial class MJIStockyardManagementArea : ExcelRow
    {
        
        public LazyRow< MJIItemPouch > RareMaterial { get; set; }
        public byte Unknown1 { get; set; }
        public LazyRow< MJIText > Area { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            RareMaterial = new LazyRow< MJIItemPouch >( gameData, parser.ReadColumn< byte >( 0 ), language );
            Unknown1 = parser.ReadColumn< byte >( 1 );
            Area = new LazyRow< MJIText >( gameData, parser.ReadColumn< ushort >( 2 ), language );
        }
    }
}