using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MonsterNote", columnHash: 0x50b4cd8f )]
    public class MonsterNote : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT


        // col: 09 offset: 0000
        public string Name;

        // col: 08 offset: 0004
        public uint Reward;

        // col: 00 offset: 0008
        public ushort[] MonsterNoteTarget;

        // col: 04 offset: 0010
        public byte[] Count;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 9 offset: 0000
            Name = parser.ReadOffset< string >( 0x0 );

            // col: 8 offset: 0004
            Reward = parser.ReadOffset< uint >( 0x4 );

            // col: 0 offset: 0008
            MonsterNoteTarget = new ushort[4];
            MonsterNoteTarget[0] = parser.ReadOffset< ushort >( 0x8 );
            MonsterNoteTarget[1] = parser.ReadOffset< ushort >( 0xa );
            MonsterNoteTarget[2] = parser.ReadOffset< ushort >( 0xc );
            MonsterNoteTarget[3] = parser.ReadOffset< ushort >( 0xe );

            // col: 4 offset: 0010
            Count = new byte[4];
            Count[0] = parser.ReadOffset< byte >( 0x10 );
            Count[1] = parser.ReadOffset< byte >( 0x11 );
            Count[2] = parser.ReadOffset< byte >( 0x12 );
            Count[3] = parser.ReadOffset< byte >( 0x13 );


        }
    }
}