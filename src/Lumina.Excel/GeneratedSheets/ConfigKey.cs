// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ConfigKey", columnHash: 0x927ebfb7 )]
    public class ConfigKey : ExcelRow
    {
        
        public SeString Label;
        public byte Param;
        public byte Platform;
        public bool Required;
        public byte Category;
        public ushort Unknown5;
        public byte Unknown6;
        public SeString Text;
        

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