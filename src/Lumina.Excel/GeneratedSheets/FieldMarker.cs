// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "FieldMarker", columnHash: 0x23003392 )]
    public class FieldMarker : ExcelRow
    {
        
        public LazyRow< VFX > VFX;
        public ushort Icon;
        public ushort Unknown2;
        public SeString Unknown3;
        

        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            VFX = new LazyRow< VFX >( gameData, parser.ReadColumn< int >( 0 ), language );
            Icon = parser.ReadColumn< ushort >( 1 );
            Unknown2 = parser.ReadColumn< ushort >( 2 );
            Unknown3 = parser.ReadColumn< SeString >( 3 );
        }
    }
}