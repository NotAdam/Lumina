// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GuildOrder", columnHash: 0xbdf9fa30 )]
    public class GuildOrder : IExcelRow
    {
        
        public LazyRow< ENpcResident > ENpcName;
        public SeString Objective;
        public SeString Description1;
        public SeString Description2;
        public SeString Description3;
        public uint CompletionBonusExp;
        public uint RewardExp;
        public uint CompletionBonusGil;
        public uint RewardGil;
        public uint Unknown9;
        public uint Unknown10;
        public uint Unknown11;
        public uint Unknown12;
        public ushort Unknown13;
        public ushort Unknown14;
        public bool Unknown15;
        public bool Unknown16;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            ENpcName = new LazyRow< ENpcResident >( lumina, parser.ReadColumn< uint >( 0 ), language );
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