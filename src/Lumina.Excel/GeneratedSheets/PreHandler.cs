// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "PreHandler", columnHash: 0xb3b4ab94 )]
    public partial class PreHandler : ExcelRow
    {
        
        public SeString Unknown0 { get; set; }
        public uint Image { get; set; }
        public uint Target { get; set; }
        public LazyRow< Quest > UnlockQuest { get; set; }
        public LazyRow< DefaultTalk > AcceptMessage { get; set; }
        public LazyRow< DefaultTalk > DenyMessage { get; set; }
        public byte Unknown6 { get; set; }
        public byte Unknown7 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< SeString >( 0 );
            Image = parser.ReadColumn< uint >( 1 );
            Target = parser.ReadColumn< uint >( 2 );
            UnlockQuest = new LazyRow< Quest >( gameData, parser.ReadColumn< uint >( 3 ), language );
            AcceptMessage = new LazyRow< DefaultTalk >( gameData, parser.ReadColumn< uint >( 4 ), language );
            DenyMessage = new LazyRow< DefaultTalk >( gameData, parser.ReadColumn< uint >( 5 ), language );
            Unknown6 = parser.ReadColumn< byte >( 6 );
            Unknown7 = parser.ReadColumn< byte >( 7 );
        }
    }
}