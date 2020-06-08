using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Knockback", columnHash: 0x6876beaf )]
    public class Knockback : IExcelRow
    {
        
        public byte Distance;
        public byte Speed;
        public bool Motion;
        public byte NearDistance;
        public byte Direction;
        public byte DirectionArg;
        public bool CancelMove;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

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