// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Tutorial", columnHash: 0x871b8a1c )]
    public class Tutorial : IExcelRow
    {
        
        public byte Unknown0;
        public byte Unknown1;
        public byte Unknown2;
        public byte Unknown3;
        public uint Exp;
        public uint Gil;
        public LazyRow< Item > RewardTank;
        public LazyRow< Item > RewardMelee;
        public LazyRow< Item > RewardRanged;
        public LazyRow< InstanceContentTextData > Objective;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Unknown0 = parser.ReadColumn< byte >( 0 );
            Unknown1 = parser.ReadColumn< byte >( 1 );
            Unknown2 = parser.ReadColumn< byte >( 2 );
            Unknown3 = parser.ReadColumn< byte >( 3 );
            Exp = parser.ReadColumn< uint >( 4 );
            Gil = parser.ReadColumn< uint >( 5 );
            RewardTank = new LazyRow< Item >( lumina, parser.ReadColumn< uint >( 6 ), language );
            RewardMelee = new LazyRow< Item >( lumina, parser.ReadColumn< uint >( 7 ), language );
            RewardRanged = new LazyRow< Item >( lumina, parser.ReadColumn< uint >( 8 ), language );
            Objective = new LazyRow< InstanceContentTextData >( lumina, parser.ReadColumn< uint >( 9 ), language );
        }
    }
}