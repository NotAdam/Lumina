using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "RecommendContents", columnHash: 0xe79dd9d4 )]
    public class RecommendContents : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public int Level;

        // col: 01 offset: 0004
        public byte ClassJob;

        // col: 02 offset: 0005
        public byte MinLevel;

        // col: 03 offset: 0006
        public byte MaxLevel;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Level = parser.ReadOffset< int >( 0x0 );

            // col: 1 offset: 0004
            ClassJob = parser.ReadOffset< byte >( 0x4 );

            // col: 2 offset: 0005
            MinLevel = parser.ReadOffset< byte >( 0x5 );

            // col: 3 offset: 0006
            MaxLevel = parser.ReadOffset< byte >( 0x6 );


        }
    }
}