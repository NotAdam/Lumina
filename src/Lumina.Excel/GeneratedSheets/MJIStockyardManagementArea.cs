// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MJIStockyardManagementArea", columnHash: 0x43bdd5b1 )]
    public partial class MJIStockyardManagementArea : ExcelRow
    {
        
        public byte Unknown0 { get; set; }
        public byte Unknown1 { get; set; }
        public ushort Unknown2 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< byte >( 0 );
            Unknown1 = parser.ReadColumn< byte >( 1 );
            Unknown2 = parser.ReadColumn< ushort >( 2 );
        }
    }
}