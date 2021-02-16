// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MonsterNote", columnHash: 0x50b4cd8f )]
    public class MonsterNote : ExcelRow
    {
        
        public LazyRow< MonsterNoteTarget >[] MonsterNoteTarget;
        public byte[] Count;
        public uint Reward;
        public SeString Name;
        

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