// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ScreenImage", columnHash: 0xf03c70eb )]
    public partial class ScreenImage : ExcelRow
    {
        
        public uint Image { get; set; }
        public LazyRow< Jingle > Jingle { get; set; }
        public sbyte Type { get; set; }
        public bool Lang { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Image = parser.ReadColumn< uint >( 0 );
            Jingle = new LazyRow< Jingle >( gameData, parser.ReadColumn< short >( 1 ), language );
            Type = parser.ReadColumn< sbyte >( 2 );
            Lang = parser.ReadColumn< bool >( 3 );
        }
    }
}