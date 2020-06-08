using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "LogMessage", columnHash: 0xf3a6d024 )]
    public class LogMessage : IExcelRow
    {
        
        public ushort LogKind;
        public ushort Unknown1;
        public byte Unknown2;
        public bool Unknown3;
        public string Text;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            LogKind = parser.ReadColumn< ushort >( 0 );
            Unknown1 = parser.ReadColumn< ushort >( 1 );
            Unknown2 = parser.ReadColumn< byte >( 2 );
            Unknown3 = parser.ReadColumn< bool >( 3 );
            Text = parser.ReadColumn< string >( 4 );
        }
    }
}