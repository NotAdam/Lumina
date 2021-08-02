// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "FishingRecordType", columnHash: 0x2c75ba5d )]
    public partial class FishingRecordType : ExcelRow
    {
        
        public LazyRow< Addon > Addon { get; set; }
        public ushort RankBRequirement { get; set; }
        public ushort RankARequirement { get; set; }
        public ushort RankAARequirement { get; set; }
        public ushort RankAAARequirement { get; set; }
        public ushort Unknown5 { get; set; }
        public byte Unknown6 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Addon = new LazyRow< Addon >( gameData, parser.ReadColumn< int >( 0 ), language );
            RankBRequirement = parser.ReadColumn< ushort >( 1 );
            RankARequirement = parser.ReadColumn< ushort >( 2 );
            RankAARequirement = parser.ReadColumn< ushort >( 3 );
            RankAAARequirement = parser.ReadColumn< ushort >( 4 );
            Unknown5 = parser.ReadColumn< ushort >( 5 );
            Unknown6 = parser.ReadColumn< byte >( 6 );
        }
    }
}