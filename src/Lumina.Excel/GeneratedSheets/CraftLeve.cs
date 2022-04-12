// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CraftLeve", columnHash: 0x51a3acc3 )]
    public class CraftLeve : ExcelRow
    {
        public class UnkData3Obj
        {
            public int Item;
            public ushort ItemCount;
        }
        
        public LazyRow< Leve > Leve { get; set; }
        public LazyRow< CraftLeveTalk > CraftLeveTalk { get; set; }
        public byte Repeats { get; set; }
        public UnkData3Obj[] UnkData3 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Leve = new LazyRow< Leve >( gameData, parser.ReadColumn< int >( 0 ), language );
            CraftLeveTalk = new LazyRow< CraftLeveTalk >( gameData, parser.ReadColumn< int >( 1 ), language );
            Repeats = parser.ReadColumn< byte >( 2 );
            UnkData3 = new UnkData3Obj[ 4 ];
            for( var i = 0; i < 4; i++ )
            {
                UnkData3[ i ] = new UnkData3Obj();
                UnkData3[ i ].Item = parser.ReadColumn< int >( 3 + ( i * 2 + 0 ) );
                UnkData3[ i ].ItemCount = parser.ReadColumn< ushort >( 3 + ( i * 2 + 1 ) );
            }
        }
    }
}