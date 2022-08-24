// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "TripleTriadResident", columnHash: 0xd870e208 )]
    public partial class TripleTriadResident : ExcelRow
    {
        
        public ushort Order { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Order = parser.ReadColumn< ushort >( 0 );
        }
    }
}