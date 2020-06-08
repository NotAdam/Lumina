using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "EquipSlotCategory", columnHash: 0xf4ab6454 )]
    public class EquipSlotCategory : IExcelRow
    {
        
        public sbyte MainHand;
        public sbyte OffHand;
        public sbyte Head;
        public sbyte Body;
        public sbyte Gloves;
        public sbyte Waist;
        public sbyte Legs;
        public sbyte Feet;
        public sbyte Ears;
        public sbyte Neck;
        public sbyte Wrists;
        public sbyte FingerL;
        public sbyte FingerR;
        public sbyte SoulCrystal;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

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