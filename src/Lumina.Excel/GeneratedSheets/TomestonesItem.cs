// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "TomestonesItem", columnHash: 0xc8901190 )]
    public partial class TomestonesItem : ExcelRow
    {
        
        public LazyRow< Item > Item { get; set; }
        public sbyte Unknown1 { get; set; }
        public LazyRow< Tomestones > Tomestones { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Item = new LazyRow< Item >( gameData, parser.ReadColumn< int >( 0 ), language );
            Unknown1 = parser.ReadColumn< sbyte >( 1 );
            Tomestones = new LazyRow< Tomestones >( gameData, parser.ReadColumn< int >( 2 ), language );
        }
    }
}