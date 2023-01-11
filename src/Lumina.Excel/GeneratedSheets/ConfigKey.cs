// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ConfigKey", columnHash: 0x927ebfb7 )]
    public partial class ConfigKey : ExcelRow
    {
        
        public SeString Label { get; set; }
        public byte Param { get; set; }
        public byte Platform { get; set; }
        public bool Required { get; set; }
        public byte Category { get; set; }
        public ushort Unknown5 { get; set; }
        public byte Unknown6 { get; set; }
        public SeString Text { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Label = parser.ReadColumn< SeString >( 0 );
            Param = parser.ReadColumn< byte >( 1 );
            Platform = parser.ReadColumn< byte >( 2 );
            Required = parser.ReadColumn< bool >( 3 );
            Category = parser.ReadColumn< byte >( 4 );
            Unknown5 = parser.ReadColumn< ushort >( 5 );
            Unknown6 = parser.ReadColumn< byte >( 6 );
            Text = parser.ReadColumn< SeString >( 7 );
        }
    }
}