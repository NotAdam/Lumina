using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Relic3", columnHash: 0xeb3c566a )]
    public class Relic3 : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT


        // col: 00 offset: 0000
        public uint ItemAnimus;

        // col: 01 offset: 0004
        public uint ItemScroll;

        // col: 03 offset: 0008
        public uint ItemNovus;

        // col: 04 offset: 000c
        public int Icon;

        // col: 02 offset: 0010
        public byte MateriaLimit;

        // col: 05 offset: 0011
        public sbyte unknown11;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            ItemAnimus = parser.ReadOffset< uint >( 0x0 );

            // col: 1 offset: 0004
            ItemScroll = parser.ReadOffset< uint >( 0x4 );

            // col: 3 offset: 0008
            ItemNovus = parser.ReadOffset< uint >( 0x8 );

            // col: 4 offset: 000c
            Icon = parser.ReadOffset< int >( 0xc );

            // col: 2 offset: 0010
            MateriaLimit = parser.ReadOffset< byte >( 0x10 );

            // col: 5 offset: 0011
            unknown11 = parser.ReadOffset< sbyte >( 0x11 );


        }
    }
}