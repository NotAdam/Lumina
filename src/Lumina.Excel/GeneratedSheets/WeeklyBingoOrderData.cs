// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "WeeklyBingoOrderData", columnHash: 0xe0f2b530 )]
    public partial class WeeklyBingoOrderData : ExcelRow
    {
        
        public uint Type { get; set; }
        public uint Data { get; set; }
        public byte Unknown2 { get; set; }
        public LazyRow< WeeklyBingoText > Text { get; set; }
        public uint Icon { get; set; }
        public byte Unknown5 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Type = parser.ReadColumn< uint >( 0 );
            Data = parser.ReadColumn< uint >( 1 );
            Unknown2 = parser.ReadColumn< byte >( 2 );
            Text = new LazyRow< WeeklyBingoText >( gameData, parser.ReadColumn< byte >( 3 ), language );
            Icon = parser.ReadColumn< uint >( 4 );
            Unknown5 = parser.ReadColumn< byte >( 5 );
        }
    }
}