using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "EquipRaceCategory", columnHash: 0xf914b198 )]
    public class EquipRaceCategory : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public bool Hyur;

        // col: 01 offset: 0001
        public bool Elezen;

        // col: 02 offset: 0002
        public bool Lalafell;

        // col: 03 offset: 0003
        public bool Miqote;

        // col: 04 offset: 0004
        public bool Roegadyn;

        // col: 05 offset: 0005
        public bool AuRa;

        // col: 06 offset: 0006
        public bool unknown6;

        // col: 07 offset: 0007
        public bool unknown7;

        // col: 08 offset: 0008
        public bool Male;
        public byte packed8;
        public bool Female;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Hyur = parser.ReadOffset< bool >( 0x0 );

            // col: 1 offset: 0001
            Elezen = parser.ReadOffset< bool >( 0x1 );

            // col: 2 offset: 0002
            Lalafell = parser.ReadOffset< bool >( 0x2 );

            // col: 3 offset: 0003
            Miqote = parser.ReadOffset< bool >( 0x3 );

            // col: 4 offset: 0004
            Roegadyn = parser.ReadOffset< bool >( 0x4 );

            // col: 5 offset: 0005
            AuRa = parser.ReadOffset< bool >( 0x5 );

            // col: 6 offset: 0006
            unknown6 = parser.ReadOffset< bool >( 0x6 );

            // col: 7 offset: 0007
            unknown7 = parser.ReadOffset< bool >( 0x7 );

            // col: 8 offset: 0008
            packed8 = parser.ReadOffset< byte >( 0x8, ExcelColumnDataType.UInt8 );

            Male = ( packed8 & 0x1 ) == 0x1;
            Female = ( packed8 & 0x2 ) == 0x2;


        }
    }
}