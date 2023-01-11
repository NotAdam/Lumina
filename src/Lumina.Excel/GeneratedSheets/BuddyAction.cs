// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "BuddyAction", columnHash: 0x9a695bec )]
    public partial class BuddyAction : ExcelRow
    {
        
        public SeString Name { get; set; }
        public SeString Description { get; set; }
        public int Icon { get; set; }
        public int IconStatus { get; set; }
        public ushort Reward { get; set; }
        public byte Sort { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Name = parser.ReadColumn< SeString >( 0 );
            Description = parser.ReadColumn< SeString >( 1 );
            Icon = parser.ReadColumn< int >( 2 );
            IconStatus = parser.ReadColumn< int >( 3 );
            Reward = parser.ReadColumn< ushort >( 4 );
            Sort = parser.ReadColumn< byte >( 5 );
        }
    }
}