// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "EmoteMode", columnHash: 0x087a32e7 )]
    public class EmoteMode : IExcelRow
    {
        
        public LazyRow< Emote > StartEmote;
        public LazyRow< Emote > EndEmote;
        public bool Move;
        public bool Camera;
        public bool EndOnRotate;
        public bool EndOnEmote;
        public byte ConditionMode;
        public bool Unknown7;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            StartEmote = new LazyRow< Emote >( lumina, parser.ReadColumn< ushort >( 0 ), language );
            EndEmote = new LazyRow< Emote >( lumina, parser.ReadColumn< ushort >( 1 ), language );
            Move = parser.ReadColumn< bool >( 2 );
            Camera = parser.ReadColumn< bool >( 3 );
            EndOnRotate = parser.ReadColumn< bool >( 4 );
            EndOnEmote = parser.ReadColumn< bool >( 5 );
            ConditionMode = parser.ReadColumn< byte >( 6 );
            Unknown7 = parser.ReadColumn< bool >( 7 );
        }
    }
}