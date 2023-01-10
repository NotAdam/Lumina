// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Tribe", columnHash: 0xe74759fb )]
    public partial class Tribe : ExcelRow
    {
        
        public SeString Masculine { get; set; }
        public SeString Feminine { get; set; }
        public sbyte Hp { get; set; }
        public sbyte Mp { get; set; }
        public sbyte STR { get; set; }
        public sbyte VIT { get; set; }
        public sbyte DEX { get; set; }
        public sbyte INT { get; set; }
        public sbyte MND { get; set; }
        public sbyte PIE { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Masculine = parser.ReadColumn< SeString >( 0 );
            Feminine = parser.ReadColumn< SeString >( 1 );
            Hp = parser.ReadColumn< sbyte >( 2 );
            Mp = parser.ReadColumn< sbyte >( 3 );
            STR = parser.ReadColumn< sbyte >( 4 );
            VIT = parser.ReadColumn< sbyte >( 5 );
            DEX = parser.ReadColumn< sbyte >( 6 );
            INT = parser.ReadColumn< sbyte >( 7 );
            MND = parser.ReadColumn< sbyte >( 8 );
            PIE = parser.ReadColumn< sbyte >( 9 );
        }
    }
}