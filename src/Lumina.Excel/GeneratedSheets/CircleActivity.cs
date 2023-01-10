// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CircleActivity", columnHash: 0x1a6ae0b3 )]
    public partial class CircleActivity : ExcelRow
    {
        
        public SeString Name { get; set; }
        public int Icon { get; set; }
        public ushort Order { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Name = parser.ReadColumn< SeString >( 0 );
            Icon = parser.ReadColumn< int >( 1 );
            Order = parser.ReadColumn< ushort >( 2 );
        }
    }
}