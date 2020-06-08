using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CompanyCraftSequence", columnHash: 0x6d444cc1 )]
    public class CompanyCraftSequence : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 13 offset: 0000
        public uint unknown0;

        // col: 00 offset: 0004
        public int ResultItem;

        // col: 01 offset: 0008
        public int unknown8;

        // col: 02 offset: 000c
        public int CompanyCraftDraftCategory;

        // col: 03 offset: 0010
        public int CompanyCraftType;

        // col: 04 offset: 0014
        public int CompanyCraftDraft;

        // col: 05 offset: 0018
        public ushort[] CompanyCraftPart;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 13 offset: 0000
            unknown0 = parser.ReadOffset< uint >( 0x0 );

            // col: 0 offset: 0004
            ResultItem = parser.ReadOffset< int >( 0x4 );

            // col: 1 offset: 0008
            unknown8 = parser.ReadOffset< int >( 0x8 );

            // col: 2 offset: 000c
            CompanyCraftDraftCategory = parser.ReadOffset< int >( 0xc );

            // col: 3 offset: 0010
            CompanyCraftType = parser.ReadOffset< int >( 0x10 );

            // col: 4 offset: 0014
            CompanyCraftDraft = parser.ReadOffset< int >( 0x14 );

            // col: 5 offset: 0018
            CompanyCraftPart = new ushort[8];
            CompanyCraftPart[0] = parser.ReadOffset< ushort >( 0x18 );
            CompanyCraftPart[1] = parser.ReadOffset< ushort >( 0x1a );
            CompanyCraftPart[2] = parser.ReadOffset< ushort >( 0x1c );
            CompanyCraftPart[3] = parser.ReadOffset< ushort >( 0x1e );
            CompanyCraftPart[4] = parser.ReadOffset< ushort >( 0x20 );
            CompanyCraftPart[5] = parser.ReadOffset< ushort >( 0x22 );
            CompanyCraftPart[6] = parser.ReadOffset< ushort >( 0x24 );
            CompanyCraftPart[7] = parser.ReadOffset< ushort >( 0x26 );


        }
    }
}