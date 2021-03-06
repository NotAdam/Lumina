// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "PvPActionSort", columnHash: 0xc3af756b )]
    public class PvPActionSort : ExcelRow
    {
        
        public byte Name { get; set; }
        public LazyRow< Action > Action { get; set; }
        public bool Unknown2 { get; set; }
        public bool Unknown3 { get; set; }
        public int Unknown4 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Name = parser.ReadColumn< byte >( 0 );
            Action = new LazyRow< Action >( gameData, parser.ReadColumn< ushort >( 1 ), language );
            Unknown2 = parser.ReadColumn< bool >( 2 );
            Unknown3 = parser.ReadColumn< bool >( 3 );
            Unknown4 = parser.ReadColumn< int >( 4 );
        }
    }
}