namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "PresetCameraAdjust", columnHash: 0x4cdff077 )]
    public class PresetCameraAdjust : IExcelRow
    {
        // column defs from Wed, 15 Jan 2020 17:17:16 GMT

        /* offset: 0000 col: 0
         *  name: Hyur_M
         *  type: 
         */

        /* offset: 0004 col: 1
         *  name: Hyur_F
         *  type: 
         */

        /* offset: 0008 col: 2
         *  name: Elezen_M
         *  type: 
         */

        /* offset: 000c col: 3
         *  name: Elezen_F
         *  type: 
         */

        /* offset: 0010 col: 4
         *  name: Lalafell_M
         *  type: 
         */

        /* offset: 0014 col: 5
         *  name: Lalafell_F
         *  type: 
         */

        /* offset: 0018 col: 6
         *  name: Miqote_M
         *  type: 
         */

        /* offset: 001c col: 7
         *  name: Miqote_F
         *  type: 
         */

        /* offset: 0020 col: 8
         *  name: Roe_M
         *  type: 
         */

        /* offset: 0024 col: 9
         *  name: Roe_F
         *  type: 
         */

        /* offset: 0028 col: 10
         *  name: Hrothgar_M
         *  type: 
         */

        /* offset: 002c col: 11
         *  name: Hrothgar_F
         *  type: 
         */

        /* offset: 0030 col: 12
         *  name: Viera_M
         *  type: 
         */

        /* offset: 0034 col: 13
         *  name: Viera_F
         *  type: 
         */



        // col: 00 offset: 0000
        public float Hyur_M;

        // col: 01 offset: 0004
        public float Hyur_F;

        // col: 02 offset: 0008
        public float Elezen_M;

        // col: 03 offset: 000c
        public float Elezen_F;

        // col: 04 offset: 0010
        public float Lalafell_M;

        // col: 05 offset: 0014
        public float Lalafell_F;

        // col: 06 offset: 0018
        public float Miqote_M;

        // col: 07 offset: 001c
        public float Miqote_F;

        // col: 08 offset: 0020
        public float Roe_M;

        // col: 09 offset: 0024
        public float Roe_F;

        // col: 10 offset: 0028
        public float Hrothgar_M;

        // col: 11 offset: 002c
        public float Hrothgar_F;

        // col: 12 offset: 0030
        public float Viera_M;

        // col: 13 offset: 0034
        public float Viera_F;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Hyur_M = parser.ReadOffset< float >( 0x0 );

            // col: 1 offset: 0004
            Hyur_F = parser.ReadOffset< float >( 0x4 );

            // col: 2 offset: 0008
            Elezen_M = parser.ReadOffset< float >( 0x8 );

            // col: 3 offset: 000c
            Elezen_F = parser.ReadOffset< float >( 0xc );

            // col: 4 offset: 0010
            Lalafell_M = parser.ReadOffset< float >( 0x10 );

            // col: 5 offset: 0014
            Lalafell_F = parser.ReadOffset< float >( 0x14 );

            // col: 6 offset: 0018
            Miqote_M = parser.ReadOffset< float >( 0x18 );

            // col: 7 offset: 001c
            Miqote_F = parser.ReadOffset< float >( 0x1c );

            // col: 8 offset: 0020
            Roe_M = parser.ReadOffset< float >( 0x20 );

            // col: 9 offset: 0024
            Roe_F = parser.ReadOffset< float >( 0x24 );

            // col: 10 offset: 0028
            Hrothgar_M = parser.ReadOffset< float >( 0x28 );

            // col: 11 offset: 002c
            Hrothgar_F = parser.ReadOffset< float >( 0x2c );

            // col: 12 offset: 0030
            Viera_M = parser.ReadOffset< float >( 0x30 );

            // col: 13 offset: 0034
            Viera_F = parser.ReadOffset< float >( 0x34 );


        }
    }
}