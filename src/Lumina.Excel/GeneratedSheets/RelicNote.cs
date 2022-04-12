// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "RelicNote", columnHash: 0xb557320e )]
    public class RelicNote : ExcelRow
    {
        public class UnkData1Obj
        {
            public ushort MonsterNoteTargetCommon;
            public byte MonsterCount;
        }
        public class UnkData25Obj
        {
            public ushort Fate;
            public ushort PlaceNameFate;
        }
        
        public LazyRow< EventItem > EventItem { get; set; }
        public UnkData1Obj[] UnkData1 { get; set; }
        public LazyRow< MonsterNoteTarget >[] MonsterNoteTargetNM { get; set; }
        public ushort Unknown24 { get; set; }
        public UnkData25Obj[] UnkData25 { get; set; }
        public LazyRow< Leve >[] Leve { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            EventItem = new LazyRow< EventItem >( gameData, parser.ReadColumn< uint >( 0 ), language );
            UnkData1 = new UnkData1Obj[ 10 ];
            for( var i = 0; i < 10; i++ )
            {
                UnkData1[ i ] = new UnkData1Obj();
                UnkData1[ i ].MonsterNoteTargetCommon = parser.ReadColumn< ushort >( 1 + ( i * 2 + 0 ) );
                UnkData1[ i ].MonsterCount = parser.ReadColumn< byte >( 1 + ( i * 2 + 1 ) );
            }
            MonsterNoteTargetNM = new LazyRow< MonsterNoteTarget >[ 3 ];
            for( var i = 0; i < 3; i++ )
                MonsterNoteTargetNM[ i ] = new LazyRow< MonsterNoteTarget >( gameData, parser.ReadColumn< ushort >( 21 + i ), language );
            Unknown24 = parser.ReadColumn< ushort >( 24 );
            UnkData25 = new UnkData25Obj[ 3 ];
            for( var i = 0; i < 3; i++ )
            {
                UnkData25[ i ] = new UnkData25Obj();
                UnkData25[ i ].Fate = parser.ReadColumn< ushort >( 25 + ( i * 2 + 0 ) );
                UnkData25[ i ].PlaceNameFate = parser.ReadColumn< ushort >( 25 + ( i * 2 + 1 ) );
            }
            Leve = new LazyRow< Leve >[ 3 ];
            for( var i = 0; i < 3; i++ )
                Leve[ i ] = new LazyRow< Leve >( gameData, parser.ReadColumn< ushort >( 31 + i ), language );
        }
    }
}