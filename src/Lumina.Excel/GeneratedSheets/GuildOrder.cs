// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GuildOrder", columnHash: 0xbdf9fa30 )]
    public partial class GuildOrder : ExcelRow
    {
        
        public LazyRow< ENpcResident > ENpcName { get; set; }
        public SeString Objective { get; set; }
        public SeString Description1 { get; set; }
        public SeString Description2 { get; set; }
        public SeString Description3 { get; set; }
        public uint CompletionBonusExp { get; set; }
        public uint RewardExp { get; set; }
        public uint CompletionBonusGil { get; set; }
        public uint RewardGil { get; set; }
        public uint Unknown9 { get; set; }
        public uint Unknown10 { get; set; }
        public uint Unknown11 { get; set; }
        public uint Unknown12 { get; set; }
        public ushort Unknown13 { get; set; }
        public ushort Unknown14 { get; set; }
        public bool Unknown15 { get; set; }
        public bool Unknown16 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            ENpcName = new LazyRow< ENpcResident >( gameData, parser.ReadColumn< uint >( 0 ), language );
            Objective = parser.ReadColumn< SeString >( 1 );
            Description1 = parser.ReadColumn< SeString >( 2 );
            Description2 = parser.ReadColumn< SeString >( 3 );
            Description3 = parser.ReadColumn< SeString >( 4 );
            CompletionBonusExp = parser.ReadColumn< uint >( 5 );
            RewardExp = parser.ReadColumn< uint >( 6 );
            CompletionBonusGil = parser.ReadColumn< uint >( 7 );
            RewardGil = parser.ReadColumn< uint >( 8 );
            Unknown9 = parser.ReadColumn< uint >( 9 );
            Unknown10 = parser.ReadColumn< uint >( 10 );
            Unknown11 = parser.ReadColumn< uint >( 11 );
            Unknown12 = parser.ReadColumn< uint >( 12 );
            Unknown13 = parser.ReadColumn< ushort >( 13 );
            Unknown14 = parser.ReadColumn< ushort >( 14 );
            Unknown15 = parser.ReadColumn< bool >( 15 );
            Unknown16 = parser.ReadColumn< bool >( 16 );
        }
    }
}