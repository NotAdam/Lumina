// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "TripleTriadRule", columnHash: 0x83e50db1 )]
    public partial class TripleTriadRule : ExcelRow
    {
        
        public SeString Name { get; set; }
        public SeString Description { get; set; }
        public byte Unknown2 { get; set; }
        public byte Unknown3 { get; set; }
        public bool Unknown4 { get; set; }
        public byte Unknown5 { get; set; }
        public int Unknown6 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Name = parser.ReadColumn< SeString >( 0 );
            Description = parser.ReadColumn< SeString >( 1 );
            Unknown2 = parser.ReadColumn< byte >( 2 );
            Unknown3 = parser.ReadColumn< byte >( 3 );
            Unknown4 = parser.ReadColumn< bool >( 4 );
            Unknown5 = parser.ReadColumn< byte >( 5 );
            Unknown6 = parser.ReadColumn< int >( 6 );
        }
    }
}