// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MonsterNote", columnHash: 0x50b4cd8f )]
    public partial class MonsterNote : ExcelRow
    {
        
        public LazyRow< MonsterNoteTarget >[] MonsterNoteTarget { get; set; }
        public byte[] Count { get; set; }
        public uint Reward { get; set; }
        public SeString Name { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            MonsterNoteTarget = new LazyRow< MonsterNoteTarget >[ 4 ];
            for( var i = 0; i < 4; i++ )
                MonsterNoteTarget[ i ] = new LazyRow< MonsterNoteTarget >( gameData, parser.ReadColumn< ushort >( 0 + i ), language );
            Count = new byte[ 4 ];
            for( var i = 0; i < 4; i++ )
                Count[ i ] = parser.ReadColumn< byte >( 4 + i );
            Reward = parser.ReadColumn< uint >( 8 );
            Name = parser.ReadColumn< SeString >( 9 );
        }
    }
}