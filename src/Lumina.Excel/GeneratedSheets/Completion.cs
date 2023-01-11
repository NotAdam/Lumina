// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Completion", columnHash: 0x2e6c55a3 )]
    public partial class Completion : ExcelRow
    {
        
        public ushort Group { get; set; }
        public ushort Key { get; set; }
        public SeString LookupTable { get; set; }
        public SeString Text { get; set; }
        public SeString GroupTitle { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Group = parser.ReadColumn< ushort >( 0 );
            Key = parser.ReadColumn< ushort >( 1 );
            LookupTable = parser.ReadColumn< SeString >( 2 );
            Text = parser.ReadColumn< SeString >( 3 );
            GroupTitle = parser.ReadColumn< SeString >( 4 );
        }
    }
}