// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CraftLeve", columnHash: 0x51a3acc3 )]
    public class CraftLeve : ExcelRow
    {
        public struct UnkStruct3Struct
        {
            public int Item;
            public ushort ItemCount;
        }
        
        public LazyRow< Leve > Leve;
        public int CraftLeveTalk;
        public byte Repeats;
        public UnkStruct3Struct[] UnkStruct3;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Leve = new LazyRow< Leve >( lumina, parser.ReadColumn< int >( 0 ), language );
            CraftLeveTalk = parser.ReadColumn< int >( 1 );
            Repeats = parser.ReadColumn< byte >( 2 );
            UnkStruct3 = new UnkStruct3Struct[ 4 ];
            for( var i = 0; i < 4; i++ )
            {
                UnkStruct3[ i ] = new UnkStruct3Struct();
                UnkStruct3[ i ].Item = parser.ReadColumn< int >( 3 + ( i * 2 + 0 ) );
                UnkStruct3[ i ].ItemCount = parser.ReadColumn< ushort >( 3 + ( i * 2 + 1 ) );
            }
        }
    }
}