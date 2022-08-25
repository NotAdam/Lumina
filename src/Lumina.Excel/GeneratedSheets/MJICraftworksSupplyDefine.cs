// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MJICraftworksSupplyDefine", columnHash: 0xeab7d419 )]
    public partial class MJICraftworksSupplyDefine : ExcelRow
    {
        
        public short Unknown0 { get; set; }
        public ushort Unknown1 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< short >( 0 );
            Unknown1 = parser.ReadColumn< ushort >( 1 );
        }
    }
}