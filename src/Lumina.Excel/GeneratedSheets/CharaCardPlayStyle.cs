// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CharaCardPlayStyle", columnHash: 0x30ebf383 )]
    public partial class CharaCardPlayStyle : ExcelRow
    {
        
        public int Icon { get; set; }
        public byte SortKey { get; set; }
        public SeString Name { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Icon = parser.ReadColumn< int >( 0 );
            SortKey = parser.ReadColumn< byte >( 1 );
            Name = parser.ReadColumn< SeString >( 2 );
        }
    }
}