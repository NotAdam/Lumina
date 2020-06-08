using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "InstanceContentBuff", columnHash: 0x2020acf6 )]
    public class InstanceContentBuff : IExcelRow
    {
        
        public ushort EchoStart;
        public ushort EchoDeath;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            EchoStart = parser.ReadColumn< ushort >( 0 );
            EchoDeath = parser.ReadColumn< ushort >( 1 );
        }
    }
}