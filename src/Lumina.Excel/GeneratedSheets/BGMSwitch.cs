// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "BGMSwitch", columnHash: 0x0989d4f2 )]
    public class BGMSwitch : ExcelRow
    {
        
        public LazyRow< BGMSystemDefine > BGMSystemDefine;
        public LazyRow< Quest > Quest;
        public byte Unknown2;
        public LazyRow< BGM > BGM;
        

        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            BGMSystemDefine = new LazyRow< BGMSystemDefine >( gameData, parser.ReadColumn< byte >( 0 ), language );
            Quest = new LazyRow< Quest >( gameData, parser.ReadColumn< uint >( 1 ), language );
            Unknown2 = parser.ReadColumn< byte >( 2 );
            BGM = new LazyRow< BGM >( gameData, parser.ReadColumn< ushort >( 3 ), language );
        }
    }
}