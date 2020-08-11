// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GardeningSeed", columnHash: 0xa8a6cb9c )]
    public class GardeningSeed : IExcelRow
    {
        
        public LazyRow< Item > Item;
        public ushort ModelID;
        public uint Icon;
        public bool SE;
        public bool Unknown4;
        public byte Unknown5;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Item = new LazyRow< Item >( lumina, parser.ReadColumn< uint >( 0 ), language );
            ModelID = parser.ReadColumn< ushort >( 1 );
            Icon = parser.ReadColumn< uint >( 2 );
            SE = parser.ReadColumn< bool >( 3 );
            Unknown4 = parser.ReadColumn< bool >( 4 );
            Unknown5 = parser.ReadColumn< byte >( 5 );
        }
    }
}