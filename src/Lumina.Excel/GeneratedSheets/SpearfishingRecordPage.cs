// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "SpearfishingRecordPage", columnHash: 0xe72da550 )]
    public partial class SpearfishingRecordPage : ExcelRow
    {
        
        public byte Unknown0 { get; set; }
        public byte Unknown1 { get; set; }
        public byte Unknown2 { get; set; }
        public LazyRow< PlaceName > PlaceName { get; set; }
        public int Image { get; set; }
        public ushort Unknown5 { get; set; }
        public byte Unknown6 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< byte >( 0 );
            Unknown1 = parser.ReadColumn< byte >( 1 );
            Unknown2 = parser.ReadColumn< byte >( 2 );
            PlaceName = new LazyRow< PlaceName >( gameData, parser.ReadColumn< int >( 3 ), language );
            Image = parser.ReadColumn< int >( 4 );
            Unknown5 = parser.ReadColumn< ushort >( 5 );
            Unknown6 = parser.ReadColumn< byte >( 6 );
        }
    }
}