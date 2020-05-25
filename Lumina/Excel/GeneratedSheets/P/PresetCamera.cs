using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "PresetCamera", columnHash: 0x7d6930eb )]
    public class PresetCamera : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 01 offset: 0000
        public float PosX;

        // col: 02 offset: 0004
        public float PosY;

        // col: 03 offset: 0008
        public float PosZ;

        // col: 04 offset: 000c
        public float Elezen;

        // col: 05 offset: 0010
        public float Lalafell;

        // col: 06 offset: 0014
        public float Miqote;

        // col: 07 offset: 0018
        public float Roe;

        // col: 08 offset: 001c
        public float Hrothgar;

        // col: 09 offset: 0020
        public float Viera;

        // col: 10 offset: 0024
        public float Hyur_F;

        // col: 11 offset: 0028
        public float Elezen_F;

        // col: 12 offset: 002c
        public float Lalafell_F;

        // col: 13 offset: 0030
        public float Miqote_F;

        // col: 14 offset: 0034
        public float Roe_F;

        // col: 15 offset: 0038
        public float Hrothgar_F;

        // col: 16 offset: 003c
        public float Viera_F;

        // col: 00 offset: 0040
        public ushort EID;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 1 offset: 0000
            PosX = parser.ReadOffset< float >( 0x0 );

            // col: 2 offset: 0004
            PosY = parser.ReadOffset< float >( 0x4 );

            // col: 3 offset: 0008
            PosZ = parser.ReadOffset< float >( 0x8 );

            // col: 4 offset: 000c
            Elezen = parser.ReadOffset< float >( 0xc );

            // col: 5 offset: 0010
            Lalafell = parser.ReadOffset< float >( 0x10 );

            // col: 6 offset: 0014
            Miqote = parser.ReadOffset< float >( 0x14 );

            // col: 7 offset: 0018
            Roe = parser.ReadOffset< float >( 0x18 );

            // col: 8 offset: 001c
            Hrothgar = parser.ReadOffset< float >( 0x1c );

            // col: 9 offset: 0020
            Viera = parser.ReadOffset< float >( 0x20 );

            // col: 10 offset: 0024
            Hyur_F = parser.ReadOffset< float >( 0x24 );

            // col: 11 offset: 0028
            Elezen_F = parser.ReadOffset< float >( 0x28 );

            // col: 12 offset: 002c
            Lalafell_F = parser.ReadOffset< float >( 0x2c );

            // col: 13 offset: 0030
            Miqote_F = parser.ReadOffset< float >( 0x30 );

            // col: 14 offset: 0034
            Roe_F = parser.ReadOffset< float >( 0x34 );

            // col: 15 offset: 0038
            Hrothgar_F = parser.ReadOffset< float >( 0x38 );

            // col: 16 offset: 003c
            Viera_F = parser.ReadOffset< float >( 0x3c );

            // col: 0 offset: 0040
            EID = parser.ReadOffset< ushort >( 0x40 );


        }
    }
}