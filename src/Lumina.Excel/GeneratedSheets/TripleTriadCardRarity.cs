// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "TripleTriadCardRarity", columnHash: 0xdcfd9eba )]
    public partial class TripleTriadCardRarity : ExcelRow
    {
        
        public byte Stars { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Stars = parser.ReadColumn< byte >( 0 );
        }
    }
}