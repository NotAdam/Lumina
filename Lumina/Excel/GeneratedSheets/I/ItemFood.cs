using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ItemFood", columnHash: 0xe09a474d )]
    public class ItemFood : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT


        // col: 04 offset: 0000
        public short unknown0;

        // col: 10 offset: 0002
        public short unknown2;

        // col: 16 offset: 0004
        public short unknown4;

        // col: 06 offset: 0006
        public short unknown6;

        // col: 12 offset: 0008
        public short unknown8;

        // col: 18 offset: 000a
        public short unknowna;

        // col: 00 offset: 000c
        public byte EXPBonusPct;

        // col: 01 offset: 000d
        public byte[] unknownd;

        // col: 07 offset: 000e
        public byte unknowne;

        // col: 13 offset: 000f
        public byte unknownf;

        // col: 09 offset: 0011
        public sbyte unknown11;

        // col: 15 offset: 0012
        public sbyte unknown12;

        // col: 05 offset: 0013
        public sbyte unknown13;

        // col: 11 offset: 0014
        public sbyte unknown14;

        // col: 17 offset: 0015
        public sbyte unknown15;

        // col: 08 offset: 0017
        public bool unknown17;

        // col: 14 offset: 0018
        public bool unknown18;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 4 offset: 0000
            unknown0 = parser.ReadOffset< short >( 0x0 );

            // col: 10 offset: 0002
            unknown2 = parser.ReadOffset< short >( 0x2 );

            // col: 16 offset: 0004
            unknown4 = parser.ReadOffset< short >( 0x4 );

            // col: 6 offset: 0006
            unknown6 = parser.ReadOffset< short >( 0x6 );

            // col: 12 offset: 0008
            unknown8 = parser.ReadOffset< short >( 0x8 );

            // col: 18 offset: 000a
            unknowna = parser.ReadOffset< short >( 0xa );

            // col: 0 offset: 000c
            EXPBonusPct = parser.ReadOffset< byte >( 0xc );

            // col: 1 offset: 000d
            unknownd = new byte[3];
            unknownd[0] = parser.ReadOffset< byte >( 0xd );
            unknownd[1] = parser.ReadOffset< byte >( 0x16 );
            unknownd[2] = parser.ReadOffset< byte >( 0x10 );

            // col: 7 offset: 000e
            unknowne = parser.ReadOffset< byte >( 0xe );

            // col: 13 offset: 000f
            unknownf = parser.ReadOffset< byte >( 0xf );

            // col: 9 offset: 0011
            unknown11 = parser.ReadOffset< sbyte >( 0x11 );

            // col: 15 offset: 0012
            unknown12 = parser.ReadOffset< sbyte >( 0x12 );

            // col: 5 offset: 0013
            unknown13 = parser.ReadOffset< sbyte >( 0x13 );

            // col: 11 offset: 0014
            unknown14 = parser.ReadOffset< sbyte >( 0x14 );

            // col: 17 offset: 0015
            unknown15 = parser.ReadOffset< sbyte >( 0x15 );

            // col: 8 offset: 0017
            unknown17 = parser.ReadOffset< bool >( 0x17 );

            // col: 14 offset: 0018
            unknown18 = parser.ReadOffset< bool >( 0x18 );


        }
    }
}