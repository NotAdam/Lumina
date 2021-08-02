// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "RelicNote", columnHash: 0xb557320e )]
    public class RelicNote : ExcelRow
    {
        public class MonsterNoteInfo
        {
            public ushort MonsterNoteTargetCommon { get; set; }
            public byte MonsterCount { get; set; }
        }
        public class FateInfo
        {
            public ushort Fate { get; set; }
            public ushort PlaceNameFate { get; set; }
        }
        
        public LazyRow< EventItem > EventItem { get; set; }
        public MonsterNoteInfo[] UnkData1 { get; set; }
        public LazyRow< MonsterNoteTarget >[] MonsterNoteTargetNM { get; set; }
        public ushort Unknown24 { get; set; }
        public FateInfo[] UnkData25 { get; set; }
        public LazyRow< Leve >[] Leve { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            EventItem = new LazyRow< EventItem >( gameData, parser.ReadColumn< uint >( 0 ), language );
            UnkData1 = new MonsterNoteInfo[ 10 ];
            for( var i = 0; i < 10; i++ )
            {
                UnkData1[ i ] = new MonsterNoteInfo();
                UnkData1[ i ].MonsterNoteTargetCommon = parser.ReadColumn< ushort >( 1 + ( i * 2 + 0 ) );
                UnkData1[ i ].MonsterCount = parser.ReadColumn< byte >( 1 + ( i * 2 + 1 ) );
            }
            MonsterNoteTargetNM = new LazyRow< MonsterNoteTarget >[ 3 ];
            for( var i = 0; i < 3; i++ )
                MonsterNoteTargetNM[ i ] = new LazyRow< MonsterNoteTarget >( gameData, parser.ReadColumn< ushort >( 21 + i ), language );
            Unknown24 = parser.ReadColumn< ushort >( 24 );
            UnkData25 = new FateInfo[ 3 ];
            for( var i = 0; i < 3; i++ )
            {
                UnkData25[ i ] = new FateInfo();
                UnkData25[ i ].Fate = parser.ReadColumn< ushort >( 25 + ( i * 2 + 0 ) );
                UnkData25[ i ].PlaceNameFate = parser.ReadColumn< ushort >( 25 + ( i * 2 + 1 ) );
            }
            Leve = new LazyRow< Leve >[ 3 ];
            for( var i = 0; i < 3; i++ )
                Leve[ i ] = new LazyRow< Leve >( gameData, parser.ReadColumn< ushort >( 31 + i ), language );
        }
    }
}