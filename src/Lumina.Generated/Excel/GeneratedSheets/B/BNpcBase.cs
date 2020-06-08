using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "BNpcBase", columnHash: 0xdd911c47 )]
    public class BNpcBase : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 04 offset: 0000
        public float Scale;

        // col: 11 offset: 0004
        public int ArrayEventHandler;

        // col: 00 offset: 0008
        public ushort Behavior;

        // col: 05 offset: 000a
        public ushort ModelChara;

        // col: 06 offset: 000c
        public ushort BNpcCustomize;

        // col: 07 offset: 000e
        public ushort NpcEquip;

        // col: 08 offset: 0010
        public ushort Special;

        // col: 01 offset: 0012
        public byte Battalion;

        // col: 02 offset: 0013
        public byte LinkRace;

        // col: 03 offset: 0014
        public byte Rank;

        // col: 09 offset: 0015
        public byte SEPack;

        // col: 12 offset: 0016
        public byte BNpcParts;

        // col: 18 offset: 0017
        public byte unknown17;

        // col: 19 offset: 0018
        public byte unknown18;

        // col: 20 offset: 0019
        public byte unknown19;

        // col: 10 offset: 001a
        public bool packed1a_1;
        public byte packed1a;
        public bool packed1a_2;
        public bool IsTargetLine;
        public bool IsDisplayLevel;
        public bool packed1a_10;
        public bool packed1a_20;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 4 offset: 0000
            Scale = parser.ReadOffset< float >( 0x0 );

            // col: 11 offset: 0004
            ArrayEventHandler = parser.ReadOffset< int >( 0x4 );

            // col: 0 offset: 0008
            Behavior = parser.ReadOffset< ushort >( 0x8 );

            // col: 5 offset: 000a
            ModelChara = parser.ReadOffset< ushort >( 0xa );

            // col: 6 offset: 000c
            BNpcCustomize = parser.ReadOffset< ushort >( 0xc );

            // col: 7 offset: 000e
            NpcEquip = parser.ReadOffset< ushort >( 0xe );

            // col: 8 offset: 0010
            Special = parser.ReadOffset< ushort >( 0x10 );

            // col: 1 offset: 0012
            Battalion = parser.ReadOffset< byte >( 0x12 );

            // col: 2 offset: 0013
            LinkRace = parser.ReadOffset< byte >( 0x13 );

            // col: 3 offset: 0014
            Rank = parser.ReadOffset< byte >( 0x14 );

            // col: 9 offset: 0015
            SEPack = parser.ReadOffset< byte >( 0x15 );

            // col: 12 offset: 0016
            BNpcParts = parser.ReadOffset< byte >( 0x16 );

            // col: 18 offset: 0017
            unknown17 = parser.ReadOffset< byte >( 0x17 );

            // col: 19 offset: 0018
            unknown18 = parser.ReadOffset< byte >( 0x18 );

            // col: 20 offset: 0019
            unknown19 = parser.ReadOffset< byte >( 0x19 );

            // col: 10 offset: 001a
            packed1a = parser.ReadOffset< byte >( 0x1a, ExcelColumnDataType.UInt8 );

            packed1a_1 = ( packed1a & 0x1 ) == 0x1;
            packed1a_2 = ( packed1a & 0x2 ) == 0x2;
            IsTargetLine = ( packed1a & 0x4 ) == 0x4;
            IsDisplayLevel = ( packed1a & 0x8 ) == 0x8;
            packed1a_10 = ( packed1a & 0x10 ) == 0x10;
            packed1a_20 = ( packed1a & 0x20 ) == 0x20;


        }
    }
}