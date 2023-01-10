// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HWDDevLively", columnHash: 0xe18cbe18 )]
    public partial class HWDDevLively : ExcelRow
    {
        
        public LazyRow< ENpcBase > ENPC { get; set; }
        public ushort Unknown1 { get; set; }
        public byte Unknown2 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            ENPC = new LazyRow< ENpcBase >( gameData, parser.ReadColumn< uint >( 0 ), language );
            Unknown1 = parser.ReadColumn< ushort >( 1 );
            Unknown2 = parser.ReadColumn< byte >( 2 );
        }
    }
}