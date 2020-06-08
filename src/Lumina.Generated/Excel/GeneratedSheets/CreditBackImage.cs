using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CreditBackImage", columnHash: 0x2b0dbd9a )]
    public class CreditBackImage : IExcelRow
    {
        
        public ushort Unknown0;
        public ushort Unknown1;
        public uint BackImage;
        public byte Unknown3;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Unknown0 = parser.ReadColumn< ushort >( 0 );
            Unknown1 = parser.ReadColumn< ushort >( 1 );
            BackImage = parser.ReadColumn< uint >( 2 );
            Unknown3 = parser.ReadColumn< byte >( 3 );
        }
    }
}