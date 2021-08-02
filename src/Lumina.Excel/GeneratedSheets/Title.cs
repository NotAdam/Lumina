// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Title", columnHash: 0x83e3f9ba )]
    public partial class Title : ExcelRow
    {
        
        public SeString Masculine { get; set; }
        public SeString Feminine { get; set; }
        public bool IsPrefix { get; set; }
        public ushort Order { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Masculine = parser.ReadColumn< SeString >( 0 );
            Feminine = parser.ReadColumn< SeString >( 1 );
            IsPrefix = parser.ReadColumn< bool >( 2 );
            Order = parser.ReadColumn< ushort >( 3 );
        }
    }
}