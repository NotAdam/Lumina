// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "NotebookDivisionCategory", columnHash: 0x9ff65ad6 )]
    public partial class NotebookDivisionCategory : ExcelRow
    {
        
        public SeString Name { get; set; }
        public byte Index { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Name = parser.ReadColumn< SeString >( 0 );
            Index = parser.ReadColumn< byte >( 1 );
        }
    }
}