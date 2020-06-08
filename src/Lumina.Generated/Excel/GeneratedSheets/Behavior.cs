using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Behavior", columnHash: 0x858a7450 )]
    public class Behavior : IExcelRow
    {
        
        public byte Unknown0;
        public byte Unknown1;
        public byte Unknown2;
        public byte Unknown3;
        public LazyRow< Balloon > Balloon;
        public short Unknown5;
        public int Unknown6;
        public ushort Unknown7;
        public ushort Unknown8;
        public byte Unknown9;
        public byte Unknown10;
        public uint Unknown11;
        public byte Unknown12;
        public byte Unknown13;
        public byte Unknown14;
        public uint Unknown15;
        public ushort Unknown16;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Unknown0 = parser.ReadColumn< byte >( 0 );
            Unknown1 = parser.ReadColumn< byte >( 1 );
            Unknown2 = parser.ReadColumn< byte >( 2 );
            Unknown3 = parser.ReadColumn< byte >( 3 );
            Balloon = new LazyRow< Balloon >( lumina, parser.ReadColumn< int >( 4 ) );
            Unknown5 = parser.ReadColumn< short >( 5 );
            Unknown6 = parser.ReadColumn< int >( 6 );
            Unknown7 = parser.ReadColumn< ushort >( 7 );
            Unknown8 = parser.ReadColumn< ushort >( 8 );
            Unknown9 = parser.ReadColumn< byte >( 9 );
            Unknown10 = parser.ReadColumn< byte >( 10 );
            Unknown11 = parser.ReadColumn< uint >( 11 );
            Unknown12 = parser.ReadColumn< byte >( 12 );
            Unknown13 = parser.ReadColumn< byte >( 13 );
            Unknown14 = parser.ReadColumn< byte >( 14 );
            Unknown15 = parser.ReadColumn< uint >( 15 );
            Unknown16 = parser.ReadColumn< ushort >( 16 );
        }
    }
}