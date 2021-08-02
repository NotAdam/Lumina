// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "FCProfile", columnHash: 0x5eb59ccb )]
    public partial class FCProfile : ExcelRow
    {
        
        public byte Priority { get; set; }
        public SeString Name { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Priority = parser.ReadColumn< byte >( 0 );
            Name = parser.ReadColumn< SeString >( 1 );
        }
    }
}