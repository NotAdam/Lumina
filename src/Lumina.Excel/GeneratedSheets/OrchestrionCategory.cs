// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "OrchestrionCategory", columnHash: 0x7ac3ee00 )]
    public class OrchestrionCategory : IExcelRow
    {
        
        public string Name;
        public byte HideCategory;
        public uint Unknown2;
        public byte Order;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Name = parser.ReadColumn< string >( 0 );
            HideCategory = parser.ReadColumn< byte >( 1 );
            Unknown2 = parser.ReadColumn< uint >( 2 );
            Order = parser.ReadColumn< byte >( 3 );
        }
    }
}