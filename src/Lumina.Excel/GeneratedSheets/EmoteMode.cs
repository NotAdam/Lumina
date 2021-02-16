// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "EmoteMode", columnHash: 0x087a32e7 )]
    public class EmoteMode : ExcelRow
    {
        
        public LazyRow< Emote > StartEmote;
        public LazyRow< Emote > EndEmote;
        public bool Move;
        public bool Camera;
        public bool EndOnRotate;
        public bool EndOnEmote;
        public byte ConditionMode;
        public bool Unknown7;
        

        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            StartEmote = new LazyRow< Emote >( gameData, parser.ReadColumn< ushort >( 0 ), language );
            EndEmote = new LazyRow< Emote >( gameData, parser.ReadColumn< ushort >( 1 ), language );
            Move = parser.ReadColumn< bool >( 2 );
            Camera = parser.ReadColumn< bool >( 3 );
            EndOnRotate = parser.ReadColumn< bool >( 4 );
            EndOnEmote = parser.ReadColumn< bool >( 5 );
            ConditionMode = parser.ReadColumn< byte >( 6 );
            Unknown7 = parser.ReadColumn< bool >( 7 );
        }
    }
}