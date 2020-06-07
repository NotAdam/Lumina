using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "IKDRoute", columnHash: 0x9a3e7720 )]
    public class IKDRoute : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 08 offset: 0000
        public string Name;

        // col: 00 offset: 0004
        public uint[] Spot;

        // col: 06 offset: 0010
        public uint Image;

        // col: 07 offset: 0014
        public uint TerritoryType;

        // col: 05 offset: 001a
        public byte TimeDefine;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 8 offset: 0000
            Name = parser.ReadOffset< string >( 0x0 );

            // col: 0 offset: 0004
            Spot = new uint[5];
            Spot[0] = parser.ReadOffset< uint >( 0x4 );
            Spot[1] = parser.ReadOffset< uint >( 0x18 );
            Spot[2] = parser.ReadOffset< uint >( 0x8 );
            Spot[3] = parser.ReadOffset< uint >( 0x19 );
            Spot[4] = parser.ReadOffset< uint >( 0xc );

            // col: 6 offset: 0010
            Image = parser.ReadOffset< uint >( 0x10 );

            // col: 7 offset: 0014
            TerritoryType = parser.ReadOffset< uint >( 0x14 );

            // col: 5 offset: 001a
            TimeDefine = parser.ReadOffset< byte >( 0x1a );


        }
    }
}