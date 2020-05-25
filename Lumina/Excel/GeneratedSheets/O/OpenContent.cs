using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "OpenContent", columnHash: 0xbdff33b7 )]
    public class OpenContent : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 16 offset: 0000
        public uint[] CandidateName;

        // col: 00 offset: 0004
        public ushort[] Content;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 16 offset: 0000
            CandidateName = new uint[16];
            CandidateName[0] = parser.ReadOffset< uint >( 0x0 );
            CandidateName[1] = parser.ReadOffset< uint >( 0x8 );
            CandidateName[2] = parser.ReadOffset< uint >( 0x10 );
            CandidateName[3] = parser.ReadOffset< uint >( 0x18 );
            CandidateName[4] = parser.ReadOffset< uint >( 0x20 );
            CandidateName[5] = parser.ReadOffset< uint >( 0x28 );
            CandidateName[6] = parser.ReadOffset< uint >( 0x30 );
            CandidateName[7] = parser.ReadOffset< uint >( 0x38 );
            CandidateName[8] = parser.ReadOffset< uint >( 0x40 );
            CandidateName[9] = parser.ReadOffset< uint >( 0x48 );
            CandidateName[10] = parser.ReadOffset< uint >( 0x50 );
            CandidateName[11] = parser.ReadOffset< uint >( 0x58 );
            CandidateName[12] = parser.ReadOffset< uint >( 0x60 );
            CandidateName[13] = parser.ReadOffset< uint >( 0x68 );
            CandidateName[14] = parser.ReadOffset< uint >( 0x70 );
            CandidateName[15] = parser.ReadOffset< uint >( 0x78 );

            // col: 0 offset: 0004
            Content = new ushort[16];
            Content[0] = parser.ReadOffset< ushort >( 0x4 );
            Content[1] = parser.ReadOffset< ushort >( 0xc );
            Content[2] = parser.ReadOffset< ushort >( 0x14 );
            Content[3] = parser.ReadOffset< ushort >( 0x1c );
            Content[4] = parser.ReadOffset< ushort >( 0x24 );
            Content[5] = parser.ReadOffset< ushort >( 0x2c );
            Content[6] = parser.ReadOffset< ushort >( 0x34 );
            Content[7] = parser.ReadOffset< ushort >( 0x3c );
            Content[8] = parser.ReadOffset< ushort >( 0x44 );
            Content[9] = parser.ReadOffset< ushort >( 0x4c );
            Content[10] = parser.ReadOffset< ushort >( 0x54 );
            Content[11] = parser.ReadOffset< ushort >( 0x5c );
            Content[12] = parser.ReadOffset< ushort >( 0x64 );
            Content[13] = parser.ReadOffset< ushort >( 0x6c );
            Content[14] = parser.ReadOffset< ushort >( 0x74 );
            Content[15] = parser.ReadOffset< ushort >( 0x7c );


        }
    }
}