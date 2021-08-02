// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "FCActivity", columnHash: 0xe45dc889 )]
    public partial class FCActivity : ExcelRow
    {
        
        public SeString Text { get; set; }
        public byte SelfKind { get; set; }
        public byte TargetKind { get; set; }
        public byte NumParam { get; set; }
        public LazyRow< FCActivityCategory > FCActivityCategory { get; set; }
        public sbyte IconType { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Text = parser.ReadColumn< SeString >( 0 );
            SelfKind = parser.ReadColumn< byte >( 1 );
            TargetKind = parser.ReadColumn< byte >( 2 );
            NumParam = parser.ReadColumn< byte >( 3 );
            FCActivityCategory = new LazyRow< FCActivityCategory >( gameData, parser.ReadColumn< byte >( 4 ), language );
            IconType = parser.ReadColumn< sbyte >( 5 );
        }
    }
}