// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "World", columnHash: 0xae743815 )]
    public partial class World : ExcelRow
    {
        
        public SeString InternalName { get; set; }
        public SeString Name { get; set; }
        public byte Region { get; set; }
        public byte UserType { get; set; }
        public LazyRow< WorldDCGroupType > DataCenter { get; set; }
        public bool IsPublic { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            InternalName = parser.ReadColumn< SeString >( 0 );
            Name = parser.ReadColumn< SeString >( 1 );
            Region = parser.ReadColumn< byte >( 2 );
            UserType = parser.ReadColumn< byte >( 3 );
            DataCenter = new LazyRow< WorldDCGroupType >( gameData, parser.ReadColumn< byte >( 4 ), language );
            IsPublic = parser.ReadColumn< bool >( 5 );
        }
    }
}