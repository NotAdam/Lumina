using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "BeastTribe", columnHash: 0x336849f0 )]
    public class BeastTribe : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 09 offset: 0000
        public string Name;

        // col: 11 offset: 0004
        public string unknown4;

        // col: 17 offset: 0008
        public string NameRelation;

        // col: 10 offset: 000c
        public sbyte unknownc;

        // col: 12 offset: 000d
        public sbyte unknownd;

        // col: 13 offset: 000e
        public sbyte unknowne;

        // col: 14 offset: 000f
        public sbyte unknownf;

        // col: 15 offset: 0010
        public sbyte unknown10;

        // col: 16 offset: 0011
        public sbyte unknown11;

        // col: 03 offset: 0014
        public uint IconReputation;

        // col: 04 offset: 0018
        public uint Icon;

        // col: 07 offset: 001c
        public uint CurrencyItem;

        // col: 01 offset: 0020
        public byte MinLevel;

        // col: 02 offset: 0021
        public byte BeastRankBonus;

        // col: 05 offset: 0022
        public byte MaxRank;

        // col: 06 offset: 0023
        public byte Expansion;

        // col: 08 offset: 0024
        public byte DisplayOrder;

        // col: 00 offset: 0025
        public bool packed25_1;
        public byte packed25;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 9 offset: 0000
            Name = parser.ReadOffset< string >( 0x0 );

            // col: 11 offset: 0004
            unknown4 = parser.ReadOffset< string >( 0x4 );

            // col: 17 offset: 0008
            NameRelation = parser.ReadOffset< string >( 0x8 );

            // col: 10 offset: 000c
            unknownc = parser.ReadOffset< sbyte >( 0xc );

            // col: 12 offset: 000d
            unknownd = parser.ReadOffset< sbyte >( 0xd );

            // col: 13 offset: 000e
            unknowne = parser.ReadOffset< sbyte >( 0xe );

            // col: 14 offset: 000f
            unknownf = parser.ReadOffset< sbyte >( 0xf );

            // col: 15 offset: 0010
            unknown10 = parser.ReadOffset< sbyte >( 0x10 );

            // col: 16 offset: 0011
            unknown11 = parser.ReadOffset< sbyte >( 0x11 );

            // col: 3 offset: 0014
            IconReputation = parser.ReadOffset< uint >( 0x14 );

            // col: 4 offset: 0018
            Icon = parser.ReadOffset< uint >( 0x18 );

            // col: 7 offset: 001c
            CurrencyItem = parser.ReadOffset< uint >( 0x1c );

            // col: 1 offset: 0020
            MinLevel = parser.ReadOffset< byte >( 0x20 );

            // col: 2 offset: 0021
            BeastRankBonus = parser.ReadOffset< byte >( 0x21 );

            // col: 5 offset: 0022
            MaxRank = parser.ReadOffset< byte >( 0x22 );

            // col: 6 offset: 0023
            Expansion = parser.ReadOffset< byte >( 0x23 );

            // col: 8 offset: 0024
            DisplayOrder = parser.ReadOffset< byte >( 0x24 );

            // col: 0 offset: 0025
            packed25 = parser.ReadOffset< byte >( 0x25, ExcelColumnDataType.UInt8 );

            packed25_1 = ( packed25 & 0x1 ) == 0x1;


        }
    }
}