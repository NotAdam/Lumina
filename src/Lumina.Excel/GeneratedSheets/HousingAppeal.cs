// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HousingAppeal", columnHash: 0xb89097b5 )]
    public partial class HousingAppeal : ExcelRow
    {
        
        public SeString Tag { get; set; }
        public uint Icon { get; set; }
        public byte Order { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Tag = parser.ReadColumn< SeString >( 0 );
            Icon = parser.ReadColumn< uint >( 1 );
            Order = parser.ReadColumn< byte >( 2 );
        }
    }
}