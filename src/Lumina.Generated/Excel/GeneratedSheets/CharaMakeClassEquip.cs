using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CharaMakeClassEquip", columnHash: 0x41dafacb )]
    public class CharaMakeClassEquip : IExcelRow
    {
        
        public ulong Helmet;
        public ulong Top;
        public ulong Glove;
        public ulong Down;
        public ulong Shoes;
        public ulong Weapon;
        public ulong SubWeapon;
        public LazyRow< ClassJob > Class;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Helmet = parser.ReadColumn< ulong >( 0 );
            Top = parser.ReadColumn< ulong >( 1 );
            Glove = parser.ReadColumn< ulong >( 2 );
            Down = parser.ReadColumn< ulong >( 3 );
            Shoes = parser.ReadColumn< ulong >( 4 );
            Weapon = parser.ReadColumn< ulong >( 5 );
            SubWeapon = parser.ReadColumn< ulong >( 6 );
            Class = new LazyRow< ClassJob >( lumina, parser.ReadColumn< int >( 7 ) );
        }
    }
}