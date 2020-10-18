// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DeepDungeonFloorEffectUI", columnHash: 0x11a44a12 )]
    public class DeepDungeonFloorEffectUI : IExcelRow
    {
        
        public uint Icon;
        public SeString Name;
        public SeString Description;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Icon = parser.ReadColumn< uint >( 0 );
            Name = parser.ReadColumn< SeString >( 1 );
            Description = parser.ReadColumn< SeString >( 2 );
        }
    }
}