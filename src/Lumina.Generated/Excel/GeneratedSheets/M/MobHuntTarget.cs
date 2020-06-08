using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MobHuntTarget", columnHash: 0x83a7f541 )]
    public class MobHuntTarget : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 02 offset: 0000
        public uint Icon;

        // col: 00 offset: 0004
        public ushort Name;

        // col: 01 offset: 0006
        public ushort FATE;

        // col: 03 offset: 0008
        public ushort TerritoryType;

        // col: 04 offset: 000a
        public ushort PlaceName;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 2 offset: 0000
            Icon = parser.ReadOffset< uint >( 0x0 );

            // col: 0 offset: 0004
            Name = parser.ReadOffset< ushort >( 0x4 );

            // col: 1 offset: 0006
            FATE = parser.ReadOffset< ushort >( 0x6 );

            // col: 3 offset: 0008
            TerritoryType = parser.ReadOffset< ushort >( 0x8 );

            // col: 4 offset: 000a
            PlaceName = parser.ReadOffset< ushort >( 0xa );


        }
    }
}