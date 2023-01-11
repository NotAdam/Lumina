// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GatheringType", columnHash: 0x182c5eea )]
    public partial class GatheringType : ExcelRow
    {
        
        public SeString Name { get; set; }
        public int IconMain { get; set; }
        public int IconOff { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Name = parser.ReadColumn< SeString >( 0 );
            IconMain = parser.ReadColumn< int >( 1 );
            IconOff = parser.ReadColumn< int >( 2 );
        }
    }
}