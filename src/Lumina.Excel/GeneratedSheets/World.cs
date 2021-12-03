// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "World", columnHash: 0xae743815 )]
    public partial class World : ExcelRow
    {
        
        public SeString Name { get; set; }
        public SeString UserType { get; set; }
        public LazyRow< WorldDCGroupType > DataCenter { get; set; }
        public byte IsPublic { get; set; }
        public byte Unknown4 { get; set; }
        public bool Unknown5 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Name = parser.ReadColumn< SeString >( 0 );
            UserType = parser.ReadColumn< SeString >( 1 );
            DataCenter = new LazyRow< WorldDCGroupType >( gameData, parser.ReadColumn< byte >( 2 ), language );
            IsPublic = parser.ReadColumn< byte >( 3 );
            Unknown4 = parser.ReadColumn< byte >( 4 );
            Unknown5 = parser.ReadColumn< bool >( 5 );
        }
    }
}