// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MJIDisposalShopItem", columnHash: 0xece42e62 )]
    public partial class MJIDisposalShopItem : ExcelRow
    {
        
        public byte Unknown0 { get; set; }
        public byte Unknown1 { get; set; }
        public ushort Unknown2 { get; set; }
        public LazyRow< MJIDisposalShopUICategory > Category { get; set; }
        public byte Unknown4 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< byte >( 0 );
            Unknown1 = parser.ReadColumn< byte >( 1 );
            Unknown2 = parser.ReadColumn< ushort >( 2 );
            Category = new LazyRow< MJIDisposalShopUICategory >( gameData, parser.ReadColumn< byte >( 3 ), language );
            Unknown4 = parser.ReadColumn< byte >( 4 );
        }
    }
}