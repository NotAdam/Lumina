// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DpsChallenge", columnHash: 0x2fdac054 )]
    public partial class DpsChallenge : ExcelRow
    {
        
        public ushort PlayerLevel { get; set; }
        public bool Unknown1 { get; set; }
        public ushort Unknown2 { get; set; }
        public LazyRow< PlaceName > PlaceName { get; set; }
        public uint Icon { get; set; }
        public ushort Order { get; set; }
        public SeString Name { get; set; }
        public SeString Description { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            PlayerLevel = parser.ReadColumn< ushort >( 0 );
            Unknown1 = parser.ReadColumn< bool >( 1 );
            Unknown2 = parser.ReadColumn< ushort >( 2 );
            PlaceName = new LazyRow< PlaceName >( gameData, parser.ReadColumn< ushort >( 3 ), language );
            Icon = parser.ReadColumn< uint >( 4 );
            Order = parser.ReadColumn< ushort >( 5 );
            Name = parser.ReadColumn< SeString >( 6 );
            Description = parser.ReadColumn< SeString >( 7 );
        }
    }
}