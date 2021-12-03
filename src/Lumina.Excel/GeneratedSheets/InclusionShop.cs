// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "InclusionShop", columnHash: 0x415e17e0 )]
    public partial class InclusionShop : ExcelRow
    {
        
        public uint Unknown0 { get; set; }
        public byte Unknown1 { get; set; }
        public LazyRow< InclusionShopCategory >[] Category { get; set; }
        public ushort Unknown32 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< uint >( 0 );
            Unknown1 = parser.ReadColumn< byte >( 1 );
            Category = new LazyRow< InclusionShopCategory >[ 30 ];
            for( var i = 0; i < 30; i++ )
                Category[ i ] = new LazyRow< InclusionShopCategory >( gameData, parser.ReadColumn< ushort >( 3 + i ), language );
            Unknown32 = parser.ReadColumn< ushort >( 32 );
        }
    }
}