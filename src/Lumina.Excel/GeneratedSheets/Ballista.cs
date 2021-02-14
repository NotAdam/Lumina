// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Ballista", columnHash: 0xcac0c160 )]
    public class Ballista : ExcelRow
    {
        
        public LazyRow< BNpcBase > BNPC;
        public sbyte Near;
        public sbyte Far;
        public ushort Angle;
        public byte Bullet;
        public byte Unknown5;
        public byte Unknown6;
        public LazyRow< Action > Action0;
        public LazyRow< Action > Action1;
        public LazyRow< Action > Action2;
        public LazyRow< Action > Action3;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            BNPC = new LazyRow< BNpcBase >( lumina, parser.ReadColumn< ushort >( 0 ), language );
            Near = parser.ReadColumn< sbyte >( 1 );
            Far = parser.ReadColumn< sbyte >( 2 );
            Angle = parser.ReadColumn< ushort >( 3 );
            Bullet = parser.ReadColumn< byte >( 4 );
            Unknown5 = parser.ReadColumn< byte >( 5 );
            Unknown6 = parser.ReadColumn< byte >( 6 );
            Action0 = new LazyRow< Action >( lumina, parser.ReadColumn< ushort >( 7 ), language );
            Action1 = new LazyRow< Action >( lumina, parser.ReadColumn< ushort >( 8 ), language );
            Action2 = new LazyRow< Action >( lumina, parser.ReadColumn< ushort >( 9 ), language );
            Action3 = new LazyRow< Action >( lumina, parser.ReadColumn< ushort >( 10 ), language );
        }
    }
}