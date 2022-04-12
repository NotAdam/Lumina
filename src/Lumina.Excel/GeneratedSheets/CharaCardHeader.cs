// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CharaCardHeader", columnHash: 0x94713f27 )]
    public class CharaCardHeader : ExcelRow
    {
        
        public int Unknown0 { get; set; }
        public int Unknown1 { get; set; }
        public byte Unknown2 { get; set; }
        public byte Unknown3 { get; set; }
        public bool Unknown4 { get; set; }
        public byte Unknown5 { get; set; }
        public ushort Unknown6 { get; set; }
        public byte Unknown7 { get; set; }
        public SeString Unknown8 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< int >( 0 );
            Unknown1 = parser.ReadColumn< int >( 1 );
            Unknown2 = parser.ReadColumn< byte >( 2 );
            Unknown3 = parser.ReadColumn< byte >( 3 );
            Unknown4 = parser.ReadColumn< bool >( 4 );
            Unknown5 = parser.ReadColumn< byte >( 5 );
            Unknown6 = parser.ReadColumn< ushort >( 6 );
            Unknown7 = parser.ReadColumn< byte >( 7 );
            Unknown8 = parser.ReadColumn< SeString >( 8 );
        }
    }
}