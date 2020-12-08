// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CreditBackImage", columnHash: 0x9ee8eba1 )]
    public class CreditBackImage : IExcelRow
    {
        
        public ushort Unknown0;
        public ushort Unknown1;
        public bool Unknown54;
        public uint BackImage;
        public byte Unknown4;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Unknown0 = parser.ReadColumn< ushort >( 0 );
            Unknown1 = parser.ReadColumn< ushort >( 1 );
            Unknown54 = parser.ReadColumn< bool >( 2 );
            BackImage = parser.ReadColumn< uint >( 3 );
            Unknown4 = parser.ReadColumn< byte >( 4 );
        }
    }
}