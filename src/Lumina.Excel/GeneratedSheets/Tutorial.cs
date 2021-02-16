// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Tutorial", columnHash: 0x871b8a1c )]
    public class Tutorial : ExcelRow
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
        

        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< byte >( 0 );
            Unknown1 = parser.ReadColumn< byte >( 1 );
            Unknown2 = parser.ReadColumn< byte >( 2 );
            Unknown3 = parser.ReadColumn< byte >( 3 );
            Exp = parser.ReadColumn< uint >( 4 );
            Gil = parser.ReadColumn< uint >( 5 );
            RewardTank = new LazyRow< Item >( gameData, parser.ReadColumn< uint >( 6 ), language );
            RewardMelee = new LazyRow< Item >( gameData, parser.ReadColumn< uint >( 7 ), language );
            RewardRanged = new LazyRow< Item >( gameData, parser.ReadColumn< uint >( 8 ), language );
            Objective = new LazyRow< InstanceContentTextData >( gameData, parser.ReadColumn< uint >( 9 ), language );
        }
    }
}