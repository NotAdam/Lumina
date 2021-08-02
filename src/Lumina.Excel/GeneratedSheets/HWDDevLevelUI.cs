// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HWDDevLevelUI", columnHash: 0xd73eab80 )]
    public partial class HWDDevLevelUI : ExcelRow
    {
        
        public byte Unknown0 { get; set; }
        public ushort Unknown1 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< byte >( 0 );
            Unknown1 = parser.ReadColumn< ushort >( 1 );
        }
    }
}