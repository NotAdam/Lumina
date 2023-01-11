// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "SubmarineRank", columnHash: 0x697b9c75 )]
    public partial class SubmarineRank : ExcelRow
    {
        
        public ushort Capacity { get; set; }
        public uint ExpToNext { get; set; }
        public byte SurveillanceBonus { get; set; }
        public byte RetrievalBonus { get; set; }
        public byte SpeedBonus { get; set; }
        public byte RangeBonus { get; set; }
        public byte FavorBonus { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Capacity = parser.ReadColumn< ushort >( 0 );
            ExpToNext = parser.ReadColumn< uint >( 1 );
            SurveillanceBonus = parser.ReadColumn< byte >( 2 );
            RetrievalBonus = parser.ReadColumn< byte >( 3 );
            SpeedBonus = parser.ReadColumn< byte >( 4 );
            RangeBonus = parser.ReadColumn< byte >( 5 );
            FavorBonus = parser.ReadColumn< byte >( 6 );
        }
    }
}