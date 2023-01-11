// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "LeveAssignmentType", columnHash: 0x7c19f23c )]
    public partial class LeveAssignmentType : ExcelRow
    {
        
        public bool IsFaction { get; set; }
        public int Icon { get; set; }
        public SeString Name { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            IsFaction = parser.ReadColumn< bool >( 0 );
            Icon = parser.ReadColumn< int >( 1 );
            Name = parser.ReadColumn< SeString >( 2 );
        }
    }
}