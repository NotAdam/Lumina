// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "WorldDCGroupType", columnHash: 0xe16c0b38 )]
    public partial class WorldDCGroupType : ExcelRow
    {
        
        public SeString Name { get; set; }
        public byte Region { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Name = parser.ReadColumn< SeString >( 0 );
            Region = parser.ReadColumn< byte >( 1 );
        }
    }
}