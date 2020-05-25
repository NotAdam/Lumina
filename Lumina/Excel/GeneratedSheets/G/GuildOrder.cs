using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GuildOrder", columnHash: 0xbdf9fa30 )]
    public class GuildOrder : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 01 offset: 0000
        public string Objective;

        // col: 02 offset: 0004
        public string Description1;

        // col: 03 offset: 0008
        public string Description2;

        // col: 04 offset: 000c
        public string Description3;

        // col: 05 offset: 0010
        public uint CompletionBonusExp;

        // col: 06 offset: 0014
        public uint RewardExp;

        // col: 07 offset: 0018
        public uint CompletionBonusGil;

        // col: 08 offset: 001c
        public uint RewardGil;

        // col: 09 offset: 0020
        public uint unknown20;

        // col: 10 offset: 0024
        public uint unknown24;

        // col: 11 offset: 0028
        public uint unknown28;

        // col: 12 offset: 002c
        public uint unknown2c;

        // col: 13 offset: 0030
        public ushort unknown30;

        // col: 14 offset: 0032
        public ushort unknown32;

        // col: 15 offset: 0034
        public bool unknown34;

        // col: 16 offset: 0035
        public bool unknown35;

        // col: 00 offset: 0038
        public uint ENpcName;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 1 offset: 0000
            Objective = parser.ReadOffset< string >( 0x0 );

            // col: 2 offset: 0004
            Description1 = parser.ReadOffset< string >( 0x4 );

            // col: 3 offset: 0008
            Description2 = parser.ReadOffset< string >( 0x8 );

            // col: 4 offset: 000c
            Description3 = parser.ReadOffset< string >( 0xc );

            // col: 5 offset: 0010
            CompletionBonusExp = parser.ReadOffset< uint >( 0x10 );

            // col: 6 offset: 0014
            RewardExp = parser.ReadOffset< uint >( 0x14 );

            // col: 7 offset: 0018
            CompletionBonusGil = parser.ReadOffset< uint >( 0x18 );

            // col: 8 offset: 001c
            RewardGil = parser.ReadOffset< uint >( 0x1c );

            // col: 9 offset: 0020
            unknown20 = parser.ReadOffset< uint >( 0x20 );

            // col: 10 offset: 0024
            unknown24 = parser.ReadOffset< uint >( 0x24 );

            // col: 11 offset: 0028
            unknown28 = parser.ReadOffset< uint >( 0x28 );

            // col: 12 offset: 002c
            unknown2c = parser.ReadOffset< uint >( 0x2c );

            // col: 13 offset: 0030
            unknown30 = parser.ReadOffset< ushort >( 0x30 );

            // col: 14 offset: 0032
            unknown32 = parser.ReadOffset< ushort >( 0x32 );

            // col: 15 offset: 0034
            unknown34 = parser.ReadOffset< bool >( 0x34 );

            // col: 16 offset: 0035
            unknown35 = parser.ReadOffset< bool >( 0x35 );

            // col: 0 offset: 0038
            ENpcName = parser.ReadOffset< uint >( 0x38 );


        }
    }
}