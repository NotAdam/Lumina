// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Knockback", columnHash: 0x6876beaf )]
    public class Knockback : ExcelRow
    {
        
        public byte Distance;
        public byte Speed;
        public bool Motion;
        public byte NearDistance;
        public byte Direction;
        public byte DirectionArg;
        public bool CancelMove;
        

        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Distance = parser.ReadColumn< byte >( 0 );
            Speed = parser.ReadColumn< byte >( 1 );
            Motion = parser.ReadColumn< bool >( 2 );
            NearDistance = parser.ReadColumn< byte >( 3 );
            Direction = parser.ReadColumn< byte >( 4 );
            DirectionArg = parser.ReadColumn< byte >( 5 );
            CancelMove = parser.ReadColumn< bool >( 6 );
        }
    }
}