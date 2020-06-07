using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "RelicItem", columnHash: 0xc8fc45d9 )]
    public class RelicItem : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 01 offset: 0000
        public uint GladiatorItem;

        // col: 02 offset: 0004
        public uint PugilistItem;

        // col: 03 offset: 0008
        public uint MarauderItem;

        // col: 04 offset: 000c
        public uint LancerItem;

        // col: 05 offset: 0010
        public uint ArcherItem;

        // col: 06 offset: 0014
        public uint ConjurerItem;

        // col: 07 offset: 0018
        public uint ThaumaturgeItem;

        // col: 08 offset: 001c
        public uint ArcanistSMNItem;

        // col: 09 offset: 0020
        public uint ArcanistSCHItem;

        // col: 10 offset: 0024
        public uint ShieldItem;

        // col: 11 offset: 0028
        public uint RogueItem;

        // col: 12 offset: 002c
        public uint unknown2c;

        // col: 13 offset: 0030
        public uint unknown30;

        // col: 14 offset: 0034
        public uint unknown34;

        // col: 15 offset: 0038
        public uint unknown38;

        // col: 16 offset: 003c
        public uint unknown3c;

        // col: 00 offset: 0040
        public byte unknown40;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 1 offset: 0000
            GladiatorItem = parser.ReadOffset< uint >( 0x0 );

            // col: 2 offset: 0004
            PugilistItem = parser.ReadOffset< uint >( 0x4 );

            // col: 3 offset: 0008
            MarauderItem = parser.ReadOffset< uint >( 0x8 );

            // col: 4 offset: 000c
            LancerItem = parser.ReadOffset< uint >( 0xc );

            // col: 5 offset: 0010
            ArcherItem = parser.ReadOffset< uint >( 0x10 );

            // col: 6 offset: 0014
            ConjurerItem = parser.ReadOffset< uint >( 0x14 );

            // col: 7 offset: 0018
            ThaumaturgeItem = parser.ReadOffset< uint >( 0x18 );

            // col: 8 offset: 001c
            ArcanistSMNItem = parser.ReadOffset< uint >( 0x1c );

            // col: 9 offset: 0020
            ArcanistSCHItem = parser.ReadOffset< uint >( 0x20 );

            // col: 10 offset: 0024
            ShieldItem = parser.ReadOffset< uint >( 0x24 );

            // col: 11 offset: 0028
            RogueItem = parser.ReadOffset< uint >( 0x28 );

            // col: 12 offset: 002c
            unknown2c = parser.ReadOffset< uint >( 0x2c );

            // col: 13 offset: 0030
            unknown30 = parser.ReadOffset< uint >( 0x30 );

            // col: 14 offset: 0034
            unknown34 = parser.ReadOffset< uint >( 0x34 );

            // col: 15 offset: 0038
            unknown38 = parser.ReadOffset< uint >( 0x38 );

            // col: 16 offset: 003c
            unknown3c = parser.ReadOffset< uint >( 0x3c );

            // col: 0 offset: 0040
            unknown40 = parser.ReadOffset< byte >( 0x40 );


        }
    }
}