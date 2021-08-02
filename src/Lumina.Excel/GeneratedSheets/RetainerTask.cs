// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "RetainerTask", columnHash: 0x99415e4e )]
    public partial class RetainerTask : ExcelRow
    {
        
        public bool IsRandom { get; set; }
        public LazyRow< ClassJobCategory > ClassJobCategory { get; set; }
        public byte RetainerLevel { get; set; }
        public ushort Unknown3 { get; set; }
        public LazyRow< RetainerTaskParameter > RetainerTaskParameter { get; set; }
        public ushort VentureCost { get; set; }
        public ushort MaxTimemin { get; set; }
        public int Experience { get; set; }
        public ushort RequiredItemLevel { get; set; }
        public byte ConditionParam0 { get; set; }
        public byte ConditionParam1 { get; set; }
        public ushort RequiredGathering { get; set; }
        public ushort Unknown12 { get; set; }
        public ushort Task { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            IsRandom = parser.ReadColumn< bool >( 0 );
            ClassJobCategory = new LazyRow< ClassJobCategory >( gameData, parser.ReadColumn< byte >( 1 ), language );
            RetainerLevel = parser.ReadColumn< byte >( 2 );
            Unknown3 = parser.ReadColumn< ushort >( 3 );
            RetainerTaskParameter = new LazyRow< RetainerTaskParameter >( gameData, parser.ReadColumn< ushort >( 4 ), language );
            VentureCost = parser.ReadColumn< ushort >( 5 );
            MaxTimemin = parser.ReadColumn< ushort >( 6 );
            Experience = parser.ReadColumn< int >( 7 );
            RequiredItemLevel = parser.ReadColumn< ushort >( 8 );
            ConditionParam0 = parser.ReadColumn< byte >( 9 );
            ConditionParam1 = parser.ReadColumn< byte >( 10 );
            RequiredGathering = parser.ReadColumn< ushort >( 11 );
            Unknown12 = parser.ReadColumn< ushort >( 12 );
            Task = parser.ReadColumn< ushort >( 13 );
        }
    }
}