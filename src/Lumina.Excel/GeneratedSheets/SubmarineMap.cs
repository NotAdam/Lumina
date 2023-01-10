// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "SubmarineMap", columnHash: 0x98fff20a )]
    public partial class SubmarineMap : ExcelRow
    {
        
        public SeString Name { get; set; }
        public uint Image { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Name = parser.ReadColumn< SeString >( 0 );
            Image = parser.ReadColumn< uint >( 1 );
        }
    }
}