using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "PublicContent", columnHash: 0xd084c410 )]
    public class PublicContent : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 03 offset: 0000
        public string Name;

        // col: 02 offset: 0004
        public uint MapIcon;

        // col: 04 offset: 0008
        public uint TextDataStart;

        // col: 05 offset: 000c
        public uint TextDataEnd;

        // col: 07 offset: 0010
        public uint unknown10;

        // col: 01 offset: 0014
        public ushort TimeLimit;

        // col: 06 offset: 0016
        public ushort unknown16;

        // col: 08 offset: 0018
        public ushort ContentFinderCondition;

        // col: 09 offset: 001a
        public ushort AdditionalData;

        // col: 11 offset: 001c
        public ushort unknown1c;

        // col: 00 offset: 001e
        public byte Type;

        // col: 10 offset: 001f
        public byte unknown1f;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 3 offset: 0000
            Name = parser.ReadOffset< string >( 0x0 );

            // col: 2 offset: 0004
            MapIcon = parser.ReadOffset< uint >( 0x4 );

            // col: 4 offset: 0008
            TextDataStart = parser.ReadOffset< uint >( 0x8 );

            // col: 5 offset: 000c
            TextDataEnd = parser.ReadOffset< uint >( 0xc );

            // col: 7 offset: 0010
            unknown10 = parser.ReadOffset< uint >( 0x10 );

            // col: 1 offset: 0014
            TimeLimit = parser.ReadOffset< ushort >( 0x14 );

            // col: 6 offset: 0016
            unknown16 = parser.ReadOffset< ushort >( 0x16 );

            // col: 8 offset: 0018
            ContentFinderCondition = parser.ReadOffset< ushort >( 0x18 );

            // col: 9 offset: 001a
            AdditionalData = parser.ReadOffset< ushort >( 0x1a );

            // col: 11 offset: 001c
            unknown1c = parser.ReadOffset< ushort >( 0x1c );

            // col: 0 offset: 001e
            Type = parser.ReadOffset< byte >( 0x1e );

            // col: 10 offset: 001f
            unknown1f = parser.ReadOffset< byte >( 0x1f );


        }
    }
}