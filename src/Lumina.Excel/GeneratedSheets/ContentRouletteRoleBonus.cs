// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ContentRouletteRoleBonus", columnHash: 0x8c1eab22 )]
    public partial class ContentRouletteRoleBonus : ExcelRow
    {
        
        public ushort Unknown0 { get; set; }
        public ushort Unknown1 { get; set; }
        public ushort Unknown2 { get; set; }
        public ushort Unknown3 { get; set; }
        public ushort Unknown4 { get; set; }
        public ushort Unknown5 { get; set; }
        public LazyRow< Item > ItemRewardType { get; set; }
        public byte RewardAmount { get; set; }
        public byte Unknown8 { get; set; }
        public uint Unknown9 { get; set; }
        public byte Unknown10 { get; set; }
        public byte Unknown11 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< ushort >( 0 );
            Unknown1 = parser.ReadColumn< ushort >( 1 );
            Unknown2 = parser.ReadColumn< ushort >( 2 );
            Unknown3 = parser.ReadColumn< ushort >( 3 );
            Unknown4 = parser.ReadColumn< ushort >( 4 );
            Unknown5 = parser.ReadColumn< ushort >( 5 );
            ItemRewardType = new LazyRow< Item >( gameData, parser.ReadColumn< uint >( 6 ), language );
            RewardAmount = parser.ReadColumn< byte >( 7 );
            Unknown8 = parser.ReadColumn< byte >( 8 );
            Unknown9 = parser.ReadColumn< uint >( 9 );
            Unknown10 = parser.ReadColumn< byte >( 10 );
            Unknown11 = parser.ReadColumn< byte >( 11 );
        }
    }
}