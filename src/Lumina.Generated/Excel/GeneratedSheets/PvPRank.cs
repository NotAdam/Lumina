// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "PvPRank", columnHash: 0xdbf43666 )]
    public class PvPRank : IExcelRow
    {
        
        public uint ExpRequired;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            ExpRequired = parser.ReadColumn< uint >( 0 );
        }
    }
}