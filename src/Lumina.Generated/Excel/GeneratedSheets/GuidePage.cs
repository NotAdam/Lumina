// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GuidePage", columnHash: 0x5bfa8a4e )]
    public class GuidePage : IExcelRow
    {
        
        public byte Key;
        public uint Output;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Key = parser.ReadColumn< byte >( 0 );
            Output = parser.ReadColumn< uint >( 1 );
        }
    }
}