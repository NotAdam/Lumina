// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MJIHudMode", columnHash: 0x649536ee )]
    public partial class MJIHudMode : ExcelRow
    {
        
        public SeString Unknown0 { get; set; }
        public SeString Unknown1 { get; set; }
        public uint Unknown2 { get; set; }
        public uint Unknown3 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< SeString >( 0 );
            Unknown1 = parser.ReadColumn< SeString >( 1 );
            Unknown2 = parser.ReadColumn< uint >( 2 );
            Unknown3 = parser.ReadColumn< uint >( 3 );
        }
    }
}