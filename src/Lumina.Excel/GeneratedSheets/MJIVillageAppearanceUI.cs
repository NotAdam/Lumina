// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MJIVillageAppearanceUI", columnHash: 0x1f6ebde2 )]
    public partial class MJIVillageAppearanceUI : ExcelRow
    {
        
        public int Unknown0 { get; set; }
        public ushort Unknown1 { get; set; }
        public ushort Unknown2 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< int >( 0 );
            Unknown1 = parser.ReadColumn< ushort >( 1 );
            Unknown2 = parser.ReadColumn< ushort >( 2 );
        }
    }
}