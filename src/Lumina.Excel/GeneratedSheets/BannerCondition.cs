// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "BannerCondition", columnHash: 0x363466df )]
    public partial class BannerCondition : ExcelRow
    {
        
        public byte UnlockType1 { get; set; }
        public uint UnlockCriteria1 { get; set; }
        public uint Unknown2 { get; set; }
        public uint Unknown3 { get; set; }
        public uint Unknown4 { get; set; }
        public uint Unknown5 { get; set; }
        public uint Unknown6 { get; set; }
        public byte UnlockType2 { get; set; }
        public uint UnlockCriteria2 { get; set; }
        public uint UnlockCriteria3 { get; set; }
        public uint UnlockCriteria4 { get; set; }
        public byte HasPrerequisite { get; set; }
        public LazyRow< Quest > Prerequisite { get; set; }
        public byte Unknown13 { get; set; }
        public bool Unknown14 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            UnlockType1 = parser.ReadColumn< byte >( 0 );
            UnlockCriteria1 = parser.ReadColumn< uint >( 1 );
            Unknown2 = parser.ReadColumn< uint >( 2 );
            Unknown3 = parser.ReadColumn< uint >( 3 );
            Unknown4 = parser.ReadColumn< uint >( 4 );
            Unknown5 = parser.ReadColumn< uint >( 5 );
            Unknown6 = parser.ReadColumn< uint >( 6 );
            UnlockType2 = parser.ReadColumn< byte >( 7 );
            UnlockCriteria2 = parser.ReadColumn< uint >( 8 );
            UnlockCriteria3 = parser.ReadColumn< uint >( 9 );
            UnlockCriteria4 = parser.ReadColumn< uint >( 10 );
            HasPrerequisite = parser.ReadColumn< byte >( 11 );
            Prerequisite = new LazyRow< Quest >( gameData, parser.ReadColumn< uint >( 12 ), language );
            Unknown13 = parser.ReadColumn< byte >( 13 );
            Unknown14 = parser.ReadColumn< bool >( 14 );
        }
    }
}