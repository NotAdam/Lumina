// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CutsceneWorkIndex", columnHash: 0xd870e208 )]
    public class CutsceneWorkIndex : IExcelRow
    {
        
        public ushort WorkIndex;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            WorkIndex = parser.ReadColumn< ushort >( 0 );
        }
    }
}