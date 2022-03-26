// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "AOZScore", columnHash: 0xefee2933 )]
    public class AOZScore : ExcelRow
    {
        
        public bool Name { get; set; }
        public int Description { get; set; }
        public SeString Score { get; set; }
        public SeString IsHidden { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Name = parser.ReadColumn< bool >( 0 );
            Description = parser.ReadColumn< int >( 1 );
            Score = parser.ReadColumn< SeString >( 2 );
            IsHidden = parser.ReadColumn< SeString >( 3 );
        }
    }
}