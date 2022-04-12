// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "BannerFrame", columnHash: 0x1c6c81a1 )]
    public class BannerFrame : ExcelRow
    {
        
        public int Unknown0 { get; set; }
        public int Unknown1 { get; set; }
        public ushort Unknown2 { get; set; }
        public ushort Unknown3 { get; set; }
        public SeString Unknown4 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< int >( 0 );
            Unknown1 = parser.ReadColumn< int >( 1 );
            Unknown2 = parser.ReadColumn< ushort >( 2 );
            Unknown3 = parser.ReadColumn< ushort >( 3 );
            Unknown4 = parser.ReadColumn< SeString >( 4 );
        }
    }
}