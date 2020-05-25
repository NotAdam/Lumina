using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ModelChara", columnHash: 0xc49c9dc2 )]
    public class ModelChara : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 01 offset: 0000
        public ushort Model;

        // col: 04 offset: 0002
        public ushort SEPack;

        // col: 00 offset: 0004
        public byte Type;

        // col: 02 offset: 0005
        public byte Base;

        // col: 03 offset: 0006
        public byte Variant;

        // col: 05 offset: 0007
        public byte unknown7;

        // col: 08 offset: 0008
        public byte unknown8;

        // col: 15 offset: 0009
        public byte unknown9;

        // col: 09 offset: 000a
        public sbyte unknowna;

        // col: 06 offset: 000b
        public bool packedb_1;
        public byte packedb;
        public bool PapVariation;
        public bool packedb_4;
        public bool packedb_8;
        public bool packedb_10;
        public bool packedb_20;
        public bool packedb_40;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 1 offset: 0000
            Model = parser.ReadOffset< ushort >( 0x0 );

            // col: 4 offset: 0002
            SEPack = parser.ReadOffset< ushort >( 0x2 );

            // col: 0 offset: 0004
            Type = parser.ReadOffset< byte >( 0x4 );

            // col: 2 offset: 0005
            Base = parser.ReadOffset< byte >( 0x5 );

            // col: 3 offset: 0006
            Variant = parser.ReadOffset< byte >( 0x6 );

            // col: 5 offset: 0007
            unknown7 = parser.ReadOffset< byte >( 0x7 );

            // col: 8 offset: 0008
            unknown8 = parser.ReadOffset< byte >( 0x8 );

            // col: 15 offset: 0009
            unknown9 = parser.ReadOffset< byte >( 0x9 );

            // col: 9 offset: 000a
            unknowna = parser.ReadOffset< sbyte >( 0xa );

            // col: 6 offset: 000b
            packedb = parser.ReadOffset< byte >( 0xb, ExcelColumnDataType.UInt8 );

            packedb_1 = ( packedb & 0x1 ) == 0x1;
            PapVariation = ( packedb & 0x2 ) == 0x2;
            packedb_4 = ( packedb & 0x4 ) == 0x4;
            packedb_8 = ( packedb & 0x8 ) == 0x8;
            packedb_10 = ( packedb & 0x10 ) == 0x10;
            packedb_20 = ( packedb & 0x20 ) == 0x20;
            packedb_40 = ( packedb & 0x40 ) == 0x40;


        }
    }
}