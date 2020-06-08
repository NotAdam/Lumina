using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "RelicNote", columnHash: 0xb557320e )]
    public class RelicNote : IExcelRow
    {
        public struct UnkStruct1Struct
        {
            public ushort MonsterNoteTargetCommon;
            public byte MonsterCount;
        }
        public struct UnkStruct25Struct
        {
            public ushort Fate;
            public ushort PlaceNameFate;
        }
        
        public LazyRow< EventItem > EventItem;
        public UnkStruct1Struct[] UnkStruct1;
        public LazyRow< MonsterNoteTarget >[] MonsterNoteTargetNM;
        public ushort Unknown24;
        public UnkStruct25Struct[] UnkStruct25;
        public LazyRow< Leve >[] Leve;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            EventItem = new LazyRow< EventItem >( lumina, parser.ReadColumn< uint >( 0 ) );
            for( var i = 0; i < 10; i++ )
            {
                UnkStruct1[ i ] = new UnkStruct1Struct();
                UnkStruct1[ i ].MonsterNoteTargetCommon = parser.ReadColumn< ushort >( 1 + ( i * 10 + 0 ) );
                UnkStruct1[ i ].MonsterCount = parser.ReadColumn< byte >( 1 + ( i * 10 + 1 ) );
            }
            for( var i = 0; i < 3; i++ )
                MonsterNoteTargetNM[ i ] = new LazyRow< MonsterNoteTarget >( lumina, parser.ReadColumn< ushort >( 21 + i ) );
            Unknown24 = parser.ReadColumn< ushort >( 24 );
            for( var i = 0; i < 3; i++ )
            {
                UnkStruct25[ i ] = new UnkStruct25Struct();
                UnkStruct25[ i ].Fate = parser.ReadColumn< ushort >( 25 + ( i * 3 + 0 ) );
                UnkStruct25[ i ].PlaceNameFate = parser.ReadColumn< ushort >( 25 + ( i * 3 + 1 ) );
            }
            for( var i = 0; i < 3; i++ )
                Leve[ i ] = new LazyRow< Leve >( lumina, parser.ReadColumn< ushort >( 31 + i ) );
        }
    }
}