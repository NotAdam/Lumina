// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DawnContent", columnHash: 0x96a22aea )]
    public partial class DawnContent : ExcelRow
    {
        
        public LazyRow< ContentFinderCondition > Content { get; set; }
        public uint Exp { get; set; }
        public uint Unknown2 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Content = new LazyRow< ContentFinderCondition >( gameData, parser.ReadColumn< uint >( 0 ), language );
            Exp = parser.ReadColumn< uint >( 1 );
            Unknown2 = parser.ReadColumn< uint >( 2 );
        }
    }
}