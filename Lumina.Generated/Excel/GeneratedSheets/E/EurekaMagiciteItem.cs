using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "EurekaMagiciteItem", columnHash: 0xbc638df5 )]
    public class EurekaMagiciteItem : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 02 offset: 0000
        public uint Item;

        // col: 00 offset: 0004
        public byte EurekaMagiciteItemType;

        // col: 01 offset: 0005
        public byte ClassJobCategory;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 2 offset: 0000
            Item = parser.ReadOffset< uint >( 0x0 );

            // col: 0 offset: 0004
            EurekaMagiciteItemType = parser.ReadOffset< byte >( 0x4 );

            // col: 1 offset: 0005
            ClassJobCategory = parser.ReadOffset< byte >( 0x5 );


        }
    }
}