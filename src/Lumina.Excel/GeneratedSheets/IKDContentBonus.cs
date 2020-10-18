// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "IKDContentBonus", columnHash: 0xb7d9b7a3 )]
    public class IKDContentBonus : IExcelRow
    {
        
        public SeString Objective;
        public SeString Requirement;
        public ushort Unknown2;
        public uint Image;
        public byte Order;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Objective = parser.ReadColumn< SeString >( 0 );
            Requirement = parser.ReadColumn< SeString >( 1 );
            Unknown2 = parser.ReadColumn< ushort >( 2 );
            Image = parser.ReadColumn< uint >( 3 );
            Order = parser.ReadColumn< byte >( 4 );
        }
    }
}