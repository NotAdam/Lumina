// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CreditList", columnHash: 0x089033fa )]
    public partial class CreditList : ExcelRow
    {
        
        public ushort Scale { get; set; }
        public uint Icon { get; set; }
        public uint Font { get; set; }
        public byte Unknown3 { get; set; }
        public byte Unknown4 { get; set; }
        public LazyRow< CreditListText > Cast { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Scale = parser.ReadColumn< ushort >( 0 );
            Icon = parser.ReadColumn< uint >( 1 );
            Font = parser.ReadColumn< uint >( 2 );
            Unknown3 = parser.ReadColumn< byte >( 3 );
            Unknown4 = parser.ReadColumn< byte >( 4 );
            Cast = new LazyRow< CreditListText >( gameData, parser.ReadColumn< uint >( 5 ), language );
        }
    }
}