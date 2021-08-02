// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DpsChallenge", columnHash: 0x944cf024 )]
    public partial class DpsChallenge : ExcelRow
    {
        
        public ushort PlayerLevel { get; set; }
        public LazyRow< PlaceName > PlaceName { get; set; }
        public uint Icon { get; set; }
        public ushort Order { get; set; }
        public SeString Name { get; set; }
        public SeString Description { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            PlayerLevel = parser.ReadColumn< ushort >( 0 );
            PlaceName = new LazyRow< PlaceName >( gameData, parser.ReadColumn< ushort >( 1 ), language );
            Icon = parser.ReadColumn< uint >( 2 );
            Order = parser.ReadColumn< ushort >( 3 );
            Name = parser.ReadColumn< SeString >( 4 );
            Description = parser.ReadColumn< SeString >( 5 );
        }
    }
}