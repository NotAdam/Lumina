// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "FieldMarker", columnHash: 0x23003392 )]
    public partial class FieldMarker : ExcelRow
    {
        
        public LazyRow< VFX > VFX { get; set; }
        public ushort UiIcon { get; set; }
        public ushort MapIcon { get; set; }
        public SeString Name { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            VFX = new LazyRow< VFX >( gameData, parser.ReadColumn< int >( 0 ), language );
            UiIcon = parser.ReadColumn< ushort >( 1 );
            MapIcon = parser.ReadColumn< ushort >( 2 );
            Name = parser.ReadColumn< SeString >( 3 );
        }
    }
}