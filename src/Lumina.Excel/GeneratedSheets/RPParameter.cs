// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "RPParameter", columnHash: 0x251a33cc )]
    public partial class RPParameter : ExcelRow
    {
        
        public LazyRow< BNpcName > BNpcName { get; set; }
        public LazyRow< ClassJob > ClassJob { get; set; }
        public byte Unknown2 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            BNpcName = new LazyRow< BNpcName >( gameData, parser.ReadColumn< ushort >( 0 ), language );
            ClassJob = new LazyRow< ClassJob >( gameData, parser.ReadColumn< byte >( 1 ), language );
            Unknown2 = parser.ReadColumn< byte >( 2 );
        }
    }
}