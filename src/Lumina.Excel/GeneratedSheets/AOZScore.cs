// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "AOZScore", columnHash: 0xefee2933 )]
    public partial class AOZScore : ExcelRow
    {
        
        public bool IsHidden { get; set; }
        public int Score { get; set; }
        public SeString Name { get; set; }
        public SeString Description { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            IsHidden = parser.ReadColumn< bool >( 0 );
            Score = parser.ReadColumn< int >( 1 );
            Name = parser.ReadColumn< SeString >( 2 );
            Description = parser.ReadColumn< SeString >( 3 );
        }
    }
}