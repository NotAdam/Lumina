// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MJIItemPouch", columnHash: 0x37dc8982 )]
    public partial class MJIItemPouch : ExcelRow
    {
        
        public LazyRow< Item > Item { get; set; }
        public int Unknown1 { get; set; }
        public byte Unknown2 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Item = new LazyRow< Item >( gameData, parser.ReadColumn< uint >( 0 ), language );
            Unknown1 = parser.ReadColumn< int >( 1 );
            Unknown2 = parser.ReadColumn< byte >( 2 );
        }
    }
}