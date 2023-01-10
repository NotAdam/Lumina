// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Description", columnHash: 0x17dc52a3 )]
    public partial class Description : ExcelRow
    {
        
        public byte Unknown0 { get; set; }
        public LazyRow< Quest > Quest { get; set; }
        public SeString TextLong { get; set; }
        public SeString TextShort { get; set; }
        public SeString TextCommentary { get; set; }
        public bool Unknown5 { get; set; }
        public LazyRow< DescriptionSection > Section { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< byte >( 0 );
            Quest = new LazyRow< Quest >( gameData, parser.ReadColumn< uint >( 1 ), language );
            TextLong = parser.ReadColumn< SeString >( 2 );
            TextShort = parser.ReadColumn< SeString >( 3 );
            TextCommentary = parser.ReadColumn< SeString >( 4 );
            Unknown5 = parser.ReadColumn< bool >( 5 );
            Section = new LazyRow< DescriptionSection >( gameData, parser.ReadColumn< uint >( 6 ), language );
        }
    }
}