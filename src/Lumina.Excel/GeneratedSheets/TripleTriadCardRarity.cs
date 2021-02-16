// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "TripleTriadCardRarity", columnHash: 0xdcfd9eba )]
    public class TripleTriadCardRarity : ExcelRow
    {
        
        public byte Stars;
        

        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Stars = parser.ReadColumn< byte >( 0 );
        }
    }
}