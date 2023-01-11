// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GroupPoseStamp", columnHash: 0x65a8a2df )]
    public partial class GroupPoseStamp : ExcelRow
    {
        
        public int StampIcon { get; set; }
        public int Unknown1 { get; set; }
        public LazyRow< GroupPoseStampCategory > Category { get; set; }
        public ushort Unknown3 { get; set; }
        public byte Unknown4 { get; set; }
        public uint Unknown5 { get; set; }
        public int Unknown6 { get; set; }
        public bool Unknown7 { get; set; }
        public bool Unknown8 { get; set; }
        public bool Unknown9 { get; set; }
        public SeString Name { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            StampIcon = parser.ReadColumn< int >( 0 );
            Unknown1 = parser.ReadColumn< int >( 1 );
            Category = new LazyRow< GroupPoseStampCategory >( gameData, parser.ReadColumn< int >( 2 ), language );
            Unknown3 = parser.ReadColumn< ushort >( 3 );
            Unknown4 = parser.ReadColumn< byte >( 4 );
            Unknown5 = parser.ReadColumn< uint >( 5 );
            Unknown6 = parser.ReadColumn< int >( 6 );
            Unknown7 = parser.ReadColumn< bool >( 7 );
            Unknown8 = parser.ReadColumn< bool >( 8 );
            Unknown9 = parser.ReadColumn< bool >( 9 );
            Name = parser.ReadColumn< SeString >( 10 );
        }
    }
}