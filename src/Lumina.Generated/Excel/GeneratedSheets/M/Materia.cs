using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Materia", columnHash: 0xc8626761 )]
    public class Materia : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public int[] Item;

        // col: 10 offset: 0028
        public byte BaseParam;

        // col: 11 offset: 0029
        public byte[] Value;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Item = new int[10];
            Item[0] = parser.ReadOffset< int >( 0x0 );
            Item[1] = parser.ReadOffset< int >( 0x4 );
            Item[2] = parser.ReadOffset< int >( 0x8 );
            Item[3] = parser.ReadOffset< int >( 0xc );
            Item[4] = parser.ReadOffset< int >( 0x10 );
            Item[5] = parser.ReadOffset< int >( 0x14 );
            Item[6] = parser.ReadOffset< int >( 0x18 );
            Item[7] = parser.ReadOffset< int >( 0x1c );
            Item[8] = parser.ReadOffset< int >( 0x20 );
            Item[9] = parser.ReadOffset< int >( 0x24 );

            // col: 10 offset: 0028
            BaseParam = parser.ReadOffset< byte >( 0x28 );

            // col: 11 offset: 0029
            Value = new byte[10];
            Value[0] = parser.ReadOffset< byte >( 0x29 );
            Value[1] = parser.ReadOffset< byte >( 0x2a );
            Value[2] = parser.ReadOffset< byte >( 0x2b );
            Value[3] = parser.ReadOffset< byte >( 0x2c );
            Value[4] = parser.ReadOffset< byte >( 0x2d );
            Value[5] = parser.ReadOffset< byte >( 0x2e );
            Value[6] = parser.ReadOffset< byte >( 0x2f );
            Value[7] = parser.ReadOffset< byte >( 0x30 );
            Value[8] = parser.ReadOffset< byte >( 0x31 );
            Value[9] = parser.ReadOffset< byte >( 0x32 );


        }
    }
}