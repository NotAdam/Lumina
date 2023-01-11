// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Attract", columnHash: 0xdb0ddee7 )]
    public partial class Attract : ExcelRow
    {
        
        public ushort MaxDistance { get; set; }
        public ushort Speed { get; set; }
        public short MinRemainingDistance { get; set; }
        public bool UseDistanceBetweenHitboxes { get; set; }
        public byte Direction { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            MaxDistance = parser.ReadColumn< ushort >( 0 );
            Speed = parser.ReadColumn< ushort >( 1 );
            MinRemainingDistance = parser.ReadColumn< short >( 2 );
            UseDistanceBetweenHitboxes = parser.ReadColumn< bool >( 3 );
            Direction = parser.ReadColumn< byte >( 4 );
        }
    }
}