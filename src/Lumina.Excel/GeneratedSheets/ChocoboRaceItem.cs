// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ChocoboRaceItem", columnHash: 0x7a3e01e7 )]
    public partial class ChocoboRaceItem : ExcelRow
    {
        
        public SeString Name { get; set; }
        public SeString Description { get; set; }
        public uint Icon { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Name = parser.ReadColumn< SeString >( 0 );
            Description = parser.ReadColumn< SeString >( 1 );
            Icon = parser.ReadColumn< uint >( 2 );
        }
    }
}