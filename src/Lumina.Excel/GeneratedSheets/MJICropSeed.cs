// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MJICropSeed", columnHash: 0xcd7b9ae9 )]
    public partial class MJICropSeed : ExcelRow
    {
        
        public LazyRow< Item > Item { get; set; }
        public LazyRow< ExportedSG > SGB { get; set; }
        public LazyRow< EObjName > Name { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Item = new LazyRow< Item >( gameData, parser.ReadColumn< uint >( 0 ), language );
            SGB = new LazyRow< ExportedSG >( gameData, parser.ReadColumn< ushort >( 1 ), language );
            Name = new LazyRow< EObjName >( gameData, parser.ReadColumn< uint >( 2 ), language );
        }
    }
}