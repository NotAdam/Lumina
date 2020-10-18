// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "BuddySkill", columnHash: 0xe3220ddc )]
    public class BuddySkill : IExcelRow
    {
        
        public byte BuddyLevel;
        public bool IsActive;
        public ushort Defender;
        public ushort Attacker;
        public ushort Healer;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            BuddyLevel = parser.ReadColumn< byte >( 0 );
            IsActive = parser.ReadColumn< bool >( 1 );
            Defender = parser.ReadColumn< ushort >( 2 );
            Attacker = parser.ReadColumn< ushort >( 3 );
            Healer = parser.ReadColumn< ushort >( 4 );
        }
    }
}