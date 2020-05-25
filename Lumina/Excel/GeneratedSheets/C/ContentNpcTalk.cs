using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ContentNpcTalk", columnHash: 0xcfa3d5cd )]
    public class ContentNpcTalk : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 01 offset: 0000
        public uint[] ContentTalk;

        // col: 00 offset: 0020
        public int Type;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 1 offset: 0000
            ContentTalk = new uint[8];
            ContentTalk[0] = parser.ReadOffset< uint >( 0x0 );
            ContentTalk[1] = parser.ReadOffset< uint >( 0x4 );
            ContentTalk[2] = parser.ReadOffset< uint >( 0x8 );
            ContentTalk[3] = parser.ReadOffset< uint >( 0xc );
            ContentTalk[4] = parser.ReadOffset< uint >( 0x10 );
            ContentTalk[5] = parser.ReadOffset< uint >( 0x14 );
            ContentTalk[6] = parser.ReadOffset< uint >( 0x18 );
            ContentTalk[7] = parser.ReadOffset< uint >( 0x1c );

            // col: 0 offset: 0020
            Type = parser.ReadOffset< int >( 0x20 );


        }
    }
}