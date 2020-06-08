using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MonsterNoteTarget", columnHash: 0x4157404f )]
    public class MonsterNoteTarget : IExcelRow
    {
        public struct UnkStruct3Struct
        {
            public ushort PlaceNameZone;
            public ushort PlaceNameLocation;
        }
        
        public LazyRow< BNpcName > BNpcName;
        public int Icon;
        public LazyRow< Town > Town;
        public UnkStruct3Struct[] UnkStruct3;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            BNpcName = new LazyRow< BNpcName >( lumina, parser.ReadColumn< ushort >( 0 ) );
            Icon = parser.ReadColumn< int >( 1 );
            Town = new LazyRow< Town >( lumina, parser.ReadColumn< byte >( 2 ) );
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