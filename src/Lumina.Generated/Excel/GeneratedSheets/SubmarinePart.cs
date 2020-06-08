using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "SubmarinePart", columnHash: 0xc971f464 )]
    public class SubmarinePart : IExcelRow
    {
        
        public byte Slot;
        public byte Rank;
        public byte Components;
        public short Surveillance;
        public short Retrieval;
        public short Speed;
        public short Range;
        public short Favor;
        public ushort Unknown8;
        public byte RepairMaterials;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Slot = parser.ReadColumn< byte >( 0 );
            Rank = parser.ReadColumn< byte >( 1 );
            Components = parser.ReadColumn< byte >( 2 );
            Surveillance = parser.ReadColumn< short >( 3 );
            Retrieval = parser.ReadColumn< short >( 4 );
            Speed = parser.ReadColumn< short >( 5 );
            Range = parser.ReadColumn< short >( 6 );
            Favor = parser.ReadColumn< short >( 7 );
            Unknown8 = parser.ReadColumn< ushort >( 8 );
            RepairMaterials = parser.ReadColumn< byte >( 9 );
        }
    }
}