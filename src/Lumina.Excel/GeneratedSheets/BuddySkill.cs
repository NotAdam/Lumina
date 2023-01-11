// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "BuddySkill", columnHash: 0xe3220ddc )]
    public partial class BuddySkill : ExcelRow
    {
        
        public byte BuddyLevel { get; set; }
        public bool IsActive { get; set; }
        public ushort Defender { get; set; }
        public ushort Attacker { get; set; }
        public ushort Healer { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            BuddyLevel = parser.ReadColumn< byte >( 0 );
            IsActive = parser.ReadColumn< bool >( 1 );
            Defender = parser.ReadColumn< ushort >( 2 );
            Attacker = parser.ReadColumn< ushort >( 3 );
            Healer = parser.ReadColumn< ushort >( 4 );
        }
    }
}