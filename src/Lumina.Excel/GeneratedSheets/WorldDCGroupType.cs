// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "WorldDCGroupType", columnHash: 0x9ff65ad6 )]
    public class WorldDCGroupType : ExcelRow
    {
        
        public SeString Name;
        public byte Region;
        

        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Name = parser.ReadColumn< SeString >( 0 );
            Region = parser.ReadColumn< byte >( 1 );
        }
    }
}