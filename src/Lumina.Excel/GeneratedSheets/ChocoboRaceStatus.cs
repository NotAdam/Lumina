// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ChocoboRaceStatus", columnHash: 0xf8ab135e )]
    public partial class ChocoboRaceStatus : ExcelRow
    {
        
        public LazyRow< Status > Status { get; set; }
        public ushort Unknown1 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Status = new LazyRow< Status >( gameData, parser.ReadColumn< int >( 0 ), language );
            Unknown1 = parser.ReadColumn< ushort >( 1 );
        }
    }
}