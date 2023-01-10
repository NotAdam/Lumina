// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "McGuffinUIData", columnHash: 0x7e82af84 )]
    public partial class McGuffinUIData : ExcelRow
    {
        
        public ushort Order { get; set; }
        public uint Icon { get; set; }
        public SeString Name { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Order = parser.ReadColumn< ushort >( 0 );
            Icon = parser.ReadColumn< uint >( 1 );
            Name = parser.ReadColumn< SeString >( 2 );
        }
    }
}