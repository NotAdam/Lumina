// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HWDAnnounce", columnHash: 0x1d91a784 )]
    public partial class HWDAnnounce : ExcelRow
    {
        
        public SeString Name { get; set; }
        public LazyRow< ENpcResident > ENPC { get; set; }
        public byte Unknown2 { get; set; }
        public byte Unknown3 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Name = parser.ReadColumn< SeString >( 0 );
            ENPC = new LazyRow< ENpcResident >( gameData, parser.ReadColumn< uint >( 1 ), language );
            Unknown2 = parser.ReadColumn< byte >( 2 );
            Unknown3 = parser.ReadColumn< byte >( 3 );
        }
    }
}