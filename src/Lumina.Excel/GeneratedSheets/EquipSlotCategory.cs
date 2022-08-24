// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "EquipSlotCategory", columnHash: 0xf4ab6454 )]
    public partial class EquipSlotCategory : ExcelRow
    {
        
        public sbyte MainHand { get; set; }
        public sbyte OffHand { get; set; }
        public sbyte Head { get; set; }
        public sbyte Body { get; set; }
        public sbyte Gloves { get; set; }
        public sbyte Waist { get; set; }
        public sbyte Legs { get; set; }
        public sbyte Feet { get; set; }
        public sbyte Ears { get; set; }
        public sbyte Neck { get; set; }
        public sbyte Wrists { get; set; }
        public sbyte FingerL { get; set; }
        public sbyte FingerR { get; set; }
        public sbyte SoulCrystal { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            MainHand = parser.ReadColumn< sbyte >( 0 );
            OffHand = parser.ReadColumn< sbyte >( 1 );
            Head = parser.ReadColumn< sbyte >( 2 );
            Body = parser.ReadColumn< sbyte >( 3 );
            Gloves = parser.ReadColumn< sbyte >( 4 );
            Waist = parser.ReadColumn< sbyte >( 5 );
            Legs = parser.ReadColumn< sbyte >( 6 );
            Feet = parser.ReadColumn< sbyte >( 7 );
            Ears = parser.ReadColumn< sbyte >( 8 );
            Neck = parser.ReadColumn< sbyte >( 9 );
            Wrists = parser.ReadColumn< sbyte >( 10 );
            FingerL = parser.ReadColumn< sbyte >( 11 );
            FingerR = parser.ReadColumn< sbyte >( 12 );
            SoulCrystal = parser.ReadColumn< sbyte >( 13 );
        }
    }
}