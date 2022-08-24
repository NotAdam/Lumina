// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "PlayerSearchSubLocation", columnHash: 0x16a4252d )]
    public partial class PlayerSearchSubLocation : ExcelRow
    {
        
        public byte Unknown0 { get; set; }
        public int Unknown1 { get; set; }
        public int Unknown2 { get; set; }
        public SeString Unknown3 { get; set; }
        public SeString Unknown4 { get; set; }
        public SeString Unknown5 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< byte >( 0 );
            Unknown1 = parser.ReadColumn< int >( 1 );
            Unknown2 = parser.ReadColumn< int >( 2 );
            Unknown3 = parser.ReadColumn< SeString >( 3 );
            Unknown4 = parser.ReadColumn< SeString >( 4 );
            Unknown5 = parser.ReadColumn< SeString >( 5 );
        }
    }
}