// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MonsterNoteTarget", columnHash: 0x4157404f )]
    public class MonsterNoteTarget : ExcelRow
    {
        public struct UnkStruct3Struct
        {
            public ushort PlaceNameZone;
            public ushort PlaceNameLocation;
        }
        
        public LazyRow< BNpcName > BNpcName { get; set; }
        public int Icon { get; set; }
        public LazyRow< Town > Town { get; set; }
        public UnkStruct3Struct[] UnkStruct3 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            BNpcName = new LazyRow< BNpcName >( gameData, parser.ReadColumn< ushort >( 0 ), language );
            Icon = parser.ReadColumn< int >( 1 );
            Town = new LazyRow< Town >( gameData, parser.ReadColumn< byte >( 2 ), language );
            UnkStruct3 = new UnkStruct3Struct[ 3 ];
            for( var i = 0; i < 3; i++ )
            {
                UnkStruct3[ i ] = new UnkStruct3Struct();
                UnkStruct3[ i ].PlaceNameZone = parser.ReadColumn< ushort >( 3 + ( i * 2 + 0 ) );
                UnkStruct3[ i ].PlaceNameLocation = parser.ReadColumn< ushort >( 3 + ( i * 2 + 1 ) );
            }
        }
    }
}