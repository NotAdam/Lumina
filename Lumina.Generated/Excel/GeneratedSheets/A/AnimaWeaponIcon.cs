using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "AnimaWeaponIcon", columnHash: 0x63c20db3 )]
    public class AnimaWeaponIcon : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public int Hyperconductive;

        // col: 01 offset: 0004
        public int Reborn;

        // col: 02 offset: 0008
        public int Sharpened;

        // col: 03 offset: 000c
        public int Zodiac;

        // col: 04 offset: 0010
        public int ZodiacLux;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Hyperconductive = parser.ReadOffset< int >( 0x0 );

            // col: 1 offset: 0004
            Reborn = parser.ReadOffset< int >( 0x4 );

            // col: 2 offset: 0008
            Sharpened = parser.ReadOffset< int >( 0x8 );

            // col: 3 offset: 000c
            Zodiac = parser.ReadOffset< int >( 0xc );

            // col: 4 offset: 0010
            ZodiacLux = parser.ReadOffset< int >( 0x10 );


        }
    }
}