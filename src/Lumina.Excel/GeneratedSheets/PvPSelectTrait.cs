// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "PvPSelectTrait", columnHash: 0xbddf8130 )]
    public partial class PvPSelectTrait : ExcelRow
    {
        
        public SeString Effect { get; set; }
        public uint Icon { get; set; }
        public short Value { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Effect = parser.ReadColumn< SeString >( 0 );
            Icon = parser.ReadColumn< uint >( 1 );
            Value = parser.ReadColumn< short >( 2 );
        }
    }
}