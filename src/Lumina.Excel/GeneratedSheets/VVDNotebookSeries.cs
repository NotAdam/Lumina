// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "VVDNotebookSeries", columnHash: 0x1b4af395 )]
    public partial class VVDNotebookSeries : ExcelRow
    {
        
        public SeString Unknown0 { get; set; }
        public int Unknown1 { get; set; }
        public int Unknown2 { get; set; }
        public int Unknown3 { get; set; }
        public int Unknown4 { get; set; }
        public int Unknown5 { get; set; }
        public int Unknown6 { get; set; }
        public int Unknown7 { get; set; }
        public int Unknown8 { get; set; }
        public int Unknown9 { get; set; }
        public int Unknown10 { get; set; }
        public int Unknown11 { get; set; }
        public int Unknown12 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< SeString >( 0 );
            Unknown1 = parser.ReadColumn< int >( 1 );
            Unknown2 = parser.ReadColumn< int >( 2 );
            Unknown3 = parser.ReadColumn< int >( 3 );
            Unknown4 = parser.ReadColumn< int >( 4 );
            Unknown5 = parser.ReadColumn< int >( 5 );
            Unknown6 = parser.ReadColumn< int >( 6 );
            Unknown7 = parser.ReadColumn< int >( 7 );
            Unknown8 = parser.ReadColumn< int >( 8 );
            Unknown9 = parser.ReadColumn< int >( 9 );
            Unknown10 = parser.ReadColumn< int >( 10 );
            Unknown11 = parser.ReadColumn< int >( 11 );
            Unknown12 = parser.ReadColumn< int >( 12 );
        }
    }
}