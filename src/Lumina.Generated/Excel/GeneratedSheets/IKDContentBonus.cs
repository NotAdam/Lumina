using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "IKDContentBonus", columnHash: 0xb7d9b7a3 )]
    public class IKDContentBonus : IExcelRow
    {
        
        public string Objective;
        public string Requirement;
        public ushort Unknown2;
        public uint Image;
        public byte Order;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Objective = parser.ReadColumn< string >( 0 );
            Requirement = parser.ReadColumn< string >( 1 );
            Unknown2 = parser.ReadColumn< ushort >( 2 );
            Image = parser.ReadColumn< uint >( 3 );
            Order = parser.ReadColumn< byte >( 4 );
        }
    }
}