// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "OnlineStatus", columnHash: 0xd87db84c )]
    public partial class OnlineStatus : ExcelRow
    {
        
        public bool List { get; set; }
        public bool Unknown1 { get; set; }
        public byte Priority { get; set; }
        public SeString Name { get; set; }
        public uint Icon { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            List = parser.ReadColumn< bool >( 0 );
            Unknown1 = parser.ReadColumn< bool >( 1 );
            Priority = parser.ReadColumn< byte >( 2 );
            Name = parser.ReadColumn< SeString >( 3 );
            Icon = parser.ReadColumn< uint >( 4 );
        }
    }
}