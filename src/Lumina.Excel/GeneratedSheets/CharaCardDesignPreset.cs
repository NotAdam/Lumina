// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CharaCardDesignPreset", columnHash: 0x2c94b01f )]
    public partial class CharaCardDesignPreset : ExcelRow
    {
        
        public LazyRow< CharaCardBase > BasePlate { get; set; }
        public LazyRow< CharaCardHeader > TopBorder { get; set; }
        public LazyRow< CharaCardHeader > BottomBorder { get; set; }
        public LazyRow< CharaCardDecoration > Backing { get; set; }
        public LazyRow< CharaCardDecoration > PatternOverlay { get; set; }
        public LazyRow< CharaCardDecoration > PortraitFrame { get; set; }
        public LazyRow< CharaCardDecoration > PlateFrame { get; set; }
        public LazyRow< CharaCardDecoration > Accent { get; set; }
        public ushort SortKey { get; set; }
        public SeString Name { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            BasePlate = new LazyRow< CharaCardBase >( gameData, parser.ReadColumn< ushort >( 0 ), language );
            TopBorder = new LazyRow< CharaCardHeader >( gameData, parser.ReadColumn< byte >( 1 ), language );
            BottomBorder = new LazyRow< CharaCardHeader >( gameData, parser.ReadColumn< byte >( 2 ), language );
            Backing = new LazyRow< CharaCardDecoration >( gameData, parser.ReadColumn< ushort >( 3 ), language );
            PatternOverlay = new LazyRow< CharaCardDecoration >( gameData, parser.ReadColumn< ushort >( 4 ), language );
            PortraitFrame = new LazyRow< CharaCardDecoration >( gameData, parser.ReadColumn< ushort >( 5 ), language );
            PlateFrame = new LazyRow< CharaCardDecoration >( gameData, parser.ReadColumn< ushort >( 6 ), language );
            Accent = new LazyRow< CharaCardDecoration >( gameData, parser.ReadColumn< ushort >( 7 ), language );
            SortKey = parser.ReadColumn< ushort >( 8 );
            Name = parser.ReadColumn< SeString >( 9 );
        }
    }
}