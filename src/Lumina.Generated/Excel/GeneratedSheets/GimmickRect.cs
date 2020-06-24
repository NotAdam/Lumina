using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GimmickRect", columnHash: 0x9be6d434 )]
    public class GimmickRect : IExcelRow
    {
        
        public uint LayoutID;
        public byte TriggerIn;
        public uint Param0;
        public uint Unknown3;
        public uint Unknown4;
        public uint Unknown5;
        public byte TriggerOut;
        public uint Param1;
        public uint Unknown8;
        public uint Unknown9;
        public uint Unknown10;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            LayoutID = parser.ReadColumn< uint >( 0 );
            TriggerIn = parser.ReadColumn< byte >( 1 );
            Param0 = parser.ReadColumn< uint >( 2 );
            Unknown3 = parser.ReadColumn< uint >( 3 );
            Unknown4 = parser.ReadColumn< uint >( 4 );
            Unknown5 = parser.ReadColumn< uint >( 5 );
            TriggerOut = parser.ReadColumn< byte >( 6 );
            Param1 = parser.ReadColumn< uint >( 7 );
            Unknown8 = parser.ReadColumn< uint >( 8 );
            Unknown9 = parser.ReadColumn< uint >( 9 );
            Unknown10 = parser.ReadColumn< uint >( 10 );
        }
    }
}