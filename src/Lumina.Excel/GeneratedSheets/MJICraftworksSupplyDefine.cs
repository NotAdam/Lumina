// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MJICraftworksSupplyDefine", columnHash: 0x1299950e )]
    public partial class MJICraftworksSupplyDefine : ExcelRow
    {
        
        public short Supply { get; set; }
        public ushort Ratio { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Supply = parser.ReadColumn< short >( 0 );
            Ratio = parser.ReadColumn< ushort >( 1 );
        }
    }
}