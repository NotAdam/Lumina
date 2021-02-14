// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "QuestBattle", columnHash: 0xd46e8441 )]
    public class QuestBattle : ExcelRow
    {
        
        public int Quest;
        public byte QuestBattleScene;
        public ushort TimeLimit;
        public ushort LevelSync;
        public SeString[] ScriptInstruction;
        public uint[] ScriptValue;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Quest = parser.ReadColumn< int >( 0 );
            QuestBattleScene = parser.ReadColumn< byte >( 1 );
            TimeLimit = parser.ReadColumn< ushort >( 2 );
            LevelSync = parser.ReadColumn< ushort >( 3 );
            ScriptInstruction = new SeString[ 200 ];
            for( var i = 0; i < 200; i++ )
                ScriptInstruction[ i ] = parser.ReadColumn< SeString >( 4 + i );
            ScriptValue = new uint[ 200 ];
            for( var i = 0; i < 200; i++ )
                ScriptValue[ i ] = parser.ReadColumn< uint >( 204 + i );
        }
    }
}