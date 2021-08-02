// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GroupPoseStamp", columnHash: 0x168074a1 )]
    public partial class GroupPoseStamp : ExcelRow
    {
        
        public int StampIcon { get; set; }
        public int Unknown1 { get; set; }
        public LazyRow< GroupPoseStampCategory > Category { get; set; }
        public ushort Unknown3 { get; set; }
        public int Unknown4 { get; set; }
        public bool Unknown5 { get; set; }
        public bool Unknown6 { get; set; }
        public bool Unknown7 { get; set; }
        public SeString Name { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            StampIcon = parser.ReadColumn< int >( 0 );
            Unknown1 = parser.ReadColumn< int >( 1 );
            Category = new LazyRow< GroupPoseStampCategory >( gameData, parser.ReadColumn< int >( 2 ), language );
            Unknown3 = parser.ReadColumn< ushort >( 3 );
            Unknown4 = parser.ReadColumn< int >( 4 );
            Unknown5 = parser.ReadColumn< bool >( 5 );
            Unknown6 = parser.ReadColumn< bool >( 6 );
            Unknown7 = parser.ReadColumn< bool >( 7 );
            Name = parser.ReadColumn< SeString >( 8 );
        }
    }
}