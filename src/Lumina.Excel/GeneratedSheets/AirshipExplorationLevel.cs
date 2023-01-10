// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "AirshipExplorationLevel", columnHash: 0x382abf74 )]
    public partial class AirshipExplorationLevel : ExcelRow
    {
        
        public ushort Capacity { get; set; }
        public uint ExpToNext { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Capacity = parser.ReadColumn< ushort >( 0 );
            ExpToNext = parser.ReadColumn< uint >( 1 );
        }
    }
}