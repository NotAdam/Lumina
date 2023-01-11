// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ModelState", columnHash: 0xd73eab80 )]
    public partial class ModelState : ExcelRow
    {
        
        public byte Unknown0 { get; set; }
        public LazyRow< ActionTimeline > Start { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< byte >( 0 );
            Start = new LazyRow< ActionTimeline >( gameData, parser.ReadColumn< ushort >( 1 ), language );
        }
    }
}