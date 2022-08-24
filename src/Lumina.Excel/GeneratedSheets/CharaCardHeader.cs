// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CharaCardHeader", columnHash: 0xb42c2ccb )]
    public partial class CharaCardHeader : ExcelRow
    {
        
        public int TopImage { get; set; }
        public int BottomImage { get; set; }
        public byte FontColor { get; set; }
        public byte Unknown3 { get; set; }
        public byte Unknown4 { get; set; }
        public byte Unknown5 { get; set; }
        public ushort Unknown6 { get; set; }
        public byte SortKey { get; set; }
        public SeString Name { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            TopImage = parser.ReadColumn< int >( 0 );
            BottomImage = parser.ReadColumn< int >( 1 );
            FontColor = parser.ReadColumn< byte >( 2 );
            Unknown3 = parser.ReadColumn< byte >( 3 );
            Unknown4 = parser.ReadColumn< byte >( 4 );
            Unknown5 = parser.ReadColumn< byte >( 5 );
            Unknown6 = parser.ReadColumn< ushort >( 6 );
            SortKey = parser.ReadColumn< byte >( 7 );
            Name = parser.ReadColumn< SeString >( 8 );
        }
    }
}