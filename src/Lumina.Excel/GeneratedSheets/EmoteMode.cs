// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "EmoteMode", columnHash: 0x087a32e7 )]
    public partial class EmoteMode : ExcelRow
    {
        
        public LazyRow< Emote > StartEmote { get; set; }
        public LazyRow< Emote > EndEmote { get; set; }
        public bool Move { get; set; }
        public bool Camera { get; set; }
        public bool EndOnRotate { get; set; }
        public bool EndOnEmote { get; set; }
        public byte ConditionMode { get; set; }
        public bool Unknown7 { get; set; }
        
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