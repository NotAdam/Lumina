using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "AnimaWeaponIcon", columnHash: 0x63c20db3 )]
    public class AnimaWeaponIcon : IExcelRow
    {
        
        public int Hyperconductive;
        public int Reborn;
        public int Sharpened;
        public int Zodiac;
        public int ZodiacLux;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Hyperconductive = parser.ReadColumn< int >( 0 );
            Reborn = parser.ReadColumn< int >( 1 );
            Sharpened = parser.ReadColumn< int >( 2 );
            Zodiac = parser.ReadColumn< int >( 3 );
            ZodiacLux = parser.ReadColumn< int >( 4 );
        }
    }
}