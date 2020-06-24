using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "SubmarineRank", columnHash: 0x697b9c75 )]
    public class SubmarineRank : IExcelRow
    {
        
        public ushort Rank;
        public uint ExpToNext;
        public byte Unknown2;
        public byte Unknown3;
        public byte Unknown4;
        public byte Unknown5;
        public byte Unknown6;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Rank = parser.ReadColumn< ushort >( 0 );
            ExpToNext = parser.ReadColumn< uint >( 1 );
            Unknown2 = parser.ReadColumn< byte >( 2 );
            Unknown3 = parser.ReadColumn< byte >( 3 );
            Unknown4 = parser.ReadColumn< byte >( 4 );
            Unknown5 = parser.ReadColumn< byte >( 5 );
            Unknown6 = parser.ReadColumn< byte >( 6 );
        }
    }
}