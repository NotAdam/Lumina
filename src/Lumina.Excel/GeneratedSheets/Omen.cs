// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Omen", columnHash: 0xd79b6c3f )]
    public class Omen : IExcelRow
    {
        
        public SeString Path;
        public SeString PathAlly;
        public byte Type;
        public bool RestrictYScale;
        public bool LargeScale;
        public sbyte Unknown5;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Path = parser.ReadColumn< SeString >( 0 );
            PathAlly = parser.ReadColumn< SeString >( 1 );
            Type = parser.ReadColumn< byte >( 2 );
            RestrictYScale = parser.ReadColumn< bool >( 3 );
            LargeScale = parser.ReadColumn< bool >( 4 );
            Unknown5 = parser.ReadColumn< sbyte >( 5 );
        }
    }
}