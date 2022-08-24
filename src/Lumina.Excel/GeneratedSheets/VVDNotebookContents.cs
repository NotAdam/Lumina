// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "VVDNotebookContents", columnHash: 0x62514e7b )]
    public partial class VVDNotebookContents : ExcelRow
    {
        
        public int Unknown0 { get; set; }
        public int Unknown1 { get; set; }
        public SeString Unknown2 { get; set; }
        public SeString Unknown3 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< int >( 0 );
            Unknown1 = parser.ReadColumn< int >( 1 );
            Unknown2 = parser.ReadColumn< SeString >( 2 );
            Unknown3 = parser.ReadColumn< SeString >( 3 );
        }
    }
}