// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MJICraftworksObject", columnHash: 0xca934bcc )]
    public partial class MJICraftworksObject : ExcelRow
    {
        public class MJICraftworksObjectUnkData4Obj
        {
            public ushort Material { get; set; }
            public ushort Amount { get; set; }
        }
        
        public LazyRow< Item > Item { get; set; }
        public LazyRow< MJICraftworksObjectTheme >[] Theme { get; set; }
        public ushort Unknown3 { get; set; }
        public MJICraftworksObjectUnkData4Obj[] UnkData4 { get; set; }
        public ushort LevelReq { get; set; }
        public ushort CraftingTime { get; set; }
        public ushort Value { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Item = new LazyRow< Item >( gameData, parser.ReadColumn< ushort >( 0 ), language );
            Theme = new LazyRow< MJICraftworksObjectTheme >[ 2 ];
            for( var i = 0; i < 2; i++ )
                Theme[ i ] = new LazyRow< MJICraftworksObjectTheme >( gameData, parser.ReadColumn< ushort >( 1 + i ), language );
            Unknown3 = parser.ReadColumn< ushort >( 3 );
            UnkData4 = new MJICraftworksObjectUnkData4Obj[ 4 ];
            for( var i = 0; i < 4; i++ )
            {
                UnkData4[ i ] = new MJICraftworksObjectUnkData4Obj();
                UnkData4[ i ].Material = parser.ReadColumn< ushort >( 4 + ( i * 2 + 0 ) );
                UnkData4[ i ].Amount = parser.ReadColumn< ushort >( 4 + ( i * 2 + 1 ) );
            }
            LevelReq = parser.ReadColumn< ushort >( 12 );
            CraftingTime = parser.ReadColumn< ushort >( 13 );
            Value = parser.ReadColumn< ushort >( 14 );
        }
    }
}