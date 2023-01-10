// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Cutscene", columnHash: 0xc7384dde )]
    public partial class Cutscene : ExcelRow
    {
        
        public SeString Path { get; set; }
        public byte Unknown1 { get; set; }
        public byte Unknown2 { get; set; }
        public bool Unknown3 { get; set; }
        public int Unknown4 { get; set; }
        public int Unknown5 { get; set; }
        public int Unknown6 { get; set; }
        public int Unknown7 { get; set; }
        public ushort Unknown8 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Path = parser.ReadColumn< SeString >( 0 );
            Unknown1 = parser.ReadColumn< byte >( 1 );
            Unknown2 = parser.ReadColumn< byte >( 2 );
            Unknown3 = parser.ReadColumn< bool >( 3 );
            Unknown4 = parser.ReadColumn< int >( 4 );
            Unknown5 = parser.ReadColumn< int >( 5 );
            Unknown6 = parser.ReadColumn< int >( 6 );
            Unknown7 = parser.ReadColumn< int >( 7 );
            Unknown8 = parser.ReadColumn< ushort >( 8 );
        }
    }
}