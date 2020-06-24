using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GuildOrderOfficer", columnHash: 0xa76e50e1 )]
    public class GuildOrderOfficer : IExcelRow
    {
        
        public uint Unknown0;
        public uint Unknown1;
        public uint Unknown2;
        public uint Unknown3;
        public uint Unknown4;
        public uint Unknown5;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Unknown0 = parser.ReadColumn< uint >( 0 );
            Unknown1 = parser.ReadColumn< uint >( 1 );
            Unknown2 = parser.ReadColumn< uint >( 2 );
            Unknown3 = parser.ReadColumn< uint >( 3 );
            Unknown4 = parser.ReadColumn< uint >( 4 );
            Unknown5 = parser.ReadColumn< uint >( 5 );
        }
    }
}