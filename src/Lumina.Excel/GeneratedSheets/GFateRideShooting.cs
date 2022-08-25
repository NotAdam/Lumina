// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GFateRideShooting", columnHash: 0xd9d6e4fa )]
    public partial class GFateRideShooting : ExcelRow
    {
        
        public uint ContentEntry { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            ContentEntry = parser.ReadColumn< uint >( 0 );
        }
    }
}