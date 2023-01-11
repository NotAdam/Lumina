// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "BGMSwitch", columnHash: 0x0989d4f2 )]
    public partial class BGMSwitch : ExcelRow
    {
        
        public LazyRow< BGMSystemDefine > BGMSystemDefine { get; set; }
        public LazyRow< Quest > Quest { get; set; }
        public byte Unknown2 { get; set; }
        public ushort BGM { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            BGMSystemDefine = new LazyRow< BGMSystemDefine >( gameData, parser.ReadColumn< byte >( 0 ), language );
            Quest = new LazyRow< Quest >( gameData, parser.ReadColumn< uint >( 1 ), language );
            Unknown2 = parser.ReadColumn< byte >( 2 );
            BGM = parser.ReadColumn< ushort >( 3 );
        }
    }
}