using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "QuestBattle", columnHash: 0x7b274910 )]
    public class QuestBattle : IExcelRow
    {
        
        public int Quest;
        public byte QuestBattleScene;
        public ushort TimeLimit;
        public ushort LevelSync;
        public string[] ScriptInstruction;
        public uint[] ScriptValue;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Quest = parser.ReadColumn< int >( 0 );
            QuestBattleScene = parser.ReadColumn< byte >( 1 );
            TimeLimit = parser.ReadColumn< ushort >( 2 );
            LevelSync = parser.ReadColumn< ushort >( 3 );
            for( var i = 0; i < 200; i++ )
                ScriptInstruction[ i ] = parser.ReadColumn< string >( 4 + i );
            for( var i = 0; i < 200; i++ )
                ScriptValue[ i ] = parser.ReadColumn< uint >( 204 + i );
        }
    }
}