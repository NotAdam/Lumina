// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Story", columnHash: 0xcaeee7ab )]
    public partial class Story : ExcelRow
    {
        
        public SeString Script { get; set; }
        public SeString[] Instruction { get; set; }
        public uint[] Argument { get; set; }
        public ushort[] Sequence { get; set; }
        public byte[] CompletedQuestOperator { get; set; }
        public LazyRow< Quest >[] CompletedQuest0 { get; set; }
        public LazyRow< Quest >[] CompletedQuest1 { get; set; }
        public LazyRow< Quest >[] CompletedQuest2 { get; set; }
        public byte[] AcceptedQuestOperator { get; set; }
        public LazyRow< Quest >[] AcceptedQuest0 { get; set; }
        public byte[] AcceptedQuestSequence0 { get; set; }
        public LazyRow< Quest >[] AcceptedQuest1 { get; set; }
        public byte[] AcceptedQuestSequence1 { get; set; }
        public LazyRow< Quest >[] AcceptedQuest2 { get; set; }
        public byte[] AcceptedQuestSequence2 { get; set; }
        public uint[] LayerSet0 { get; set; }
        public uint[] LayerSet1 { get; set; }
        public ushort[] SequenceBegin { get; set; }
        public ushort[] SequenceEnd { get; set; }
        public uint[] Listener { get; set; }
        public LazyRow< TerritoryType > LayerSetTerritoryType0 { get; set; }
        public LazyRow< TerritoryType > LayerSetTerritoryType1 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Script = parser.ReadColumn< SeString >( 0 );
            Instruction = new SeString[ 40 ];
            for( var i = 0; i < 40; i++ )
                Instruction[ i ] = parser.ReadColumn< SeString >( 1 + i );
            Argument = new uint[ 40 ];
            for( var i = 0; i < 40; i++ )
                Argument[ i ] = parser.ReadColumn< uint >( 41 + i );
            Sequence = new ushort[ 110 ];
            for( var i = 0; i < 110; i++ )
                Sequence[ i ] = parser.ReadColumn< ushort >( 81 + i );
            CompletedQuestOperator = new byte[ 110 ];
            for( var i = 0; i < 110; i++ )
                CompletedQuestOperator[ i ] = parser.ReadColumn< byte >( 191 + i );
            CompletedQuest0 = new LazyRow< Quest >[ 110 ];
            for( var i = 0; i < 110; i++ )
                CompletedQuest0[ i ] = new LazyRow< Quest >( gameData, parser.ReadColumn< uint >( 301 + i ), language );
            CompletedQuest1 = new LazyRow< Quest >[ 110 ];
            for( var i = 0; i < 110; i++ )
                CompletedQuest1[ i ] = new LazyRow< Quest >( gameData, parser.ReadColumn< uint >( 411 + i ), language );
            CompletedQuest2 = new LazyRow< Quest >[ 110 ];
            for( var i = 0; i < 110; i++ )
                CompletedQuest2[ i ] = new LazyRow< Quest >( gameData, parser.ReadColumn< uint >( 521 + i ), language );
            AcceptedQuestOperator = new byte[ 110 ];
            for( var i = 0; i < 110; i++ )
                AcceptedQuestOperator[ i ] = parser.ReadColumn< byte >( 631 + i );
            AcceptedQuest0 = new LazyRow< Quest >[ 110 ];
            for( var i = 0; i < 110; i++ )
                AcceptedQuest0[ i ] = new LazyRow< Quest >( gameData, parser.ReadColumn< uint >( 741 + i ), language );
            AcceptedQuestSequence0 = new byte[ 110 ];
            for( var i = 0; i < 110; i++ )
                AcceptedQuestSequence0[ i ] = parser.ReadColumn< byte >( 851 + i );
            AcceptedQuest1 = new LazyRow< Quest >[ 110 ];
            for( var i = 0; i < 110; i++ )
                AcceptedQuest1[ i ] = new LazyRow< Quest >( gameData, parser.ReadColumn< uint >( 961 + i ), language );
            AcceptedQuestSequence1 = new byte[ 110 ];
            for( var i = 0; i < 110; i++ )
                AcceptedQuestSequence1[ i ] = parser.ReadColumn< byte >( 1071 + i );
            AcceptedQuest2 = new LazyRow< Quest >[ 110 ];
            for( var i = 0; i < 110; i++ )
                AcceptedQuest2[ i ] = new LazyRow< Quest >( gameData, parser.ReadColumn< uint >( 1181 + i ), language );
            AcceptedQuestSequence2 = new byte[ 110 ];
            for( var i = 0; i < 110; i++ )
                AcceptedQuestSequence2[ i ] = parser.ReadColumn< byte >( 1291 + i );
            LayerSet0 = new uint[ 110 ];
            for( var i = 0; i < 110; i++ )
                LayerSet0[ i ] = parser.ReadColumn< uint >( 1401 + i );
            LayerSet1 = new uint[ 110 ];
            for( var i = 0; i < 110; i++ )
                LayerSet1[ i ] = parser.ReadColumn< uint >( 1511 + i );
            SequenceBegin = new ushort[ 80 ];
            for( var i = 0; i < 80; i++ )
                SequenceBegin[ i ] = parser.ReadColumn< ushort >( 1621 + i );
            SequenceEnd = new ushort[ 80 ];
            for( var i = 0; i < 80; i++ )
                SequenceEnd[ i ] = parser.ReadColumn< ushort >( 1701 + i );
            Listener = new uint[ 80 ];
            for( var i = 0; i < 80; i++ )
                Listener[ i ] = parser.ReadColumn< uint >( 1781 + i );
            LayerSetTerritoryType0 = new LazyRow< TerritoryType >( gameData, parser.ReadColumn< ushort >( 1861 ), language );
            LayerSetTerritoryType1 = new LazyRow< TerritoryType >( gameData, parser.ReadColumn< ushort >( 1862 ), language );
        }
    }
}