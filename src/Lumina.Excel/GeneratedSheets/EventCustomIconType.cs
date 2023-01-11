// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "EventCustomIconType", columnHash: 0x9a111885 )]
    public partial class EventCustomIconType : ExcelRow
    {
        
        public uint[] AnnounceQuest { get; set; }
        public uint[] AnnounceQuestLocked { get; set; }
        public uint[] MapAnnounceQuest0 { get; set; }
        public uint[] MapAnnounceQuestLocked { get; set; }
        public uint[] MapAnnounceQuest1 { get; set; }
        public byte Unknown50 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            AnnounceQuest = new uint[ 10 ];
            for( var i = 0; i < 10; i++ )
                AnnounceQuest[ i ] = parser.ReadColumn< uint >( 0 + i );
            AnnounceQuestLocked = new uint[ 10 ];
            for( var i = 0; i < 10; i++ )
                AnnounceQuestLocked[ i ] = parser.ReadColumn< uint >( 10 + i );
            MapAnnounceQuest0 = new uint[ 10 ];
            for( var i = 0; i < 10; i++ )
                MapAnnounceQuest0[ i ] = parser.ReadColumn< uint >( 20 + i );
            MapAnnounceQuestLocked = new uint[ 10 ];
            for( var i = 0; i < 10; i++ )
                MapAnnounceQuestLocked[ i ] = parser.ReadColumn< uint >( 30 + i );
            MapAnnounceQuest1 = new uint[ 10 ];
            for( var i = 0; i < 10; i++ )
                MapAnnounceQuest1[ i ] = parser.ReadColumn< uint >( 40 + i );
            Unknown50 = parser.ReadColumn< byte >( 50 );
        }
    }
}