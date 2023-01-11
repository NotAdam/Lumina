// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "NotoriousMonster", columnHash: 0x307c9206 )]
    public partial class NotoriousMonster : ExcelRow
    {
        
        public LazyRow< BNpcBase > BNpcBase { get; set; }
        public byte Rank { get; set; }
        public LazyRow< BNpcName > BNpcName { get; set; }
        public ushort Unknown3 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            BNpcBase = new LazyRow< BNpcBase >( gameData, parser.ReadColumn< int >( 0 ), language );
            Rank = parser.ReadColumn< byte >( 1 );
            BNpcName = new LazyRow< BNpcName >( gameData, parser.ReadColumn< uint >( 2 ), language );
            Unknown3 = parser.ReadColumn< ushort >( 3 );
        }
    }
}