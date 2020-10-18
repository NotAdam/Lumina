// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "AquariumWater", columnHash: 0x5eb59ccb )]
    public class AquariumWater : IExcelRow
    {
        
        public byte Unknown0;
        public SeString Name;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Unknown0 = parser.ReadColumn< byte >( 0 );
            Name = parser.ReadColumn< SeString >( 1 );
        }
    }
}