// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "IKDContentBonus", columnHash: 0xb7d9b7a3 )]
    public partial class IKDContentBonus : ExcelRow
    {
        
        public SeString Objective { get; set; }
        public SeString Requirement { get; set; }
        public ushort Unknown2 { get; set; }
        public uint Image { get; set; }
        public byte Order { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Objective = parser.ReadColumn< SeString >( 0 );
            Requirement = parser.ReadColumn< SeString >( 1 );
            Unknown2 = parser.ReadColumn< ushort >( 2 );
            Image = parser.ReadColumn< uint >( 3 );
            Order = parser.ReadColumn< byte >( 4 );
        }
    }
}