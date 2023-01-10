// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Omen", columnHash: 0xd79b6c3f )]
    public partial class Omen : ExcelRow
    {
        
        public SeString Path { get; set; }
        public SeString PathAlly { get; set; }
        public byte Type { get; set; }
        public bool RestrictYScale { get; set; }
        public bool LargeScale { get; set; }
        public sbyte Unknown5 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Path = parser.ReadColumn< SeString >( 0 );
            PathAlly = parser.ReadColumn< SeString >( 1 );
            Type = parser.ReadColumn< byte >( 2 );
            RestrictYScale = parser.ReadColumn< bool >( 3 );
            LargeScale = parser.ReadColumn< bool >( 4 );
            Unknown5 = parser.ReadColumn< sbyte >( 5 );
        }
    }
}