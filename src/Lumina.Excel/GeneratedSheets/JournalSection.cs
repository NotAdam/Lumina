// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "JournalSection", columnHash: 0x754a1dcd )]
    public partial class JournalSection : ExcelRow
    {
        
        public SeString Name { get; set; }
        public bool Unknown1 { get; set; }
        public bool Unknown2 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Name = parser.ReadColumn< SeString >( 0 );
            Unknown1 = parser.ReadColumn< bool >( 1 );
            Unknown2 = parser.ReadColumn< bool >( 2 );
        }
    }
}