// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CharaCardBase", columnHash: 0x2e632858 )]
    public class CharaCardBase : ExcelRow
    {
        
        public int Unknown0 { get; set; }
        public byte Unknown1 { get; set; }
        public bool Unknown2 { get; set; }
        public bool Unknown3 { get; set; }
        public byte Unknown4 { get; set; }
        public ushort Unknown5 { get; set; }
        public ushort Unknown6 { get; set; }
        public SeString Unknown7 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< int >( 0 );
            Unknown1 = parser.ReadColumn< byte >( 1 );
            Unknown2 = parser.ReadColumn< bool >( 2 );
            Unknown3 = parser.ReadColumn< bool >( 3 );
            Unknown4 = parser.ReadColumn< byte >( 4 );
            Unknown5 = parser.ReadColumn< ushort >( 5 );
            Unknown6 = parser.ReadColumn< ushort >( 6 );
            Unknown7 = parser.ReadColumn< SeString >( 7 );
        }
    }
}