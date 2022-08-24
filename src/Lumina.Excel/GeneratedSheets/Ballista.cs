// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Ballista", columnHash: 0xcac0c160 )]
    public partial class Ballista : ExcelRow
    {
        
        public LazyRow< BNpcBase > BNPC { get; set; }
        public sbyte Near { get; set; }
        public sbyte Far { get; set; }
        public ushort Angle { get; set; }
        public byte Bullet { get; set; }
        public byte Unknown5 { get; set; }
        public byte Unknown6 { get; set; }
        public LazyRow< Action > Action0 { get; set; }
        public LazyRow< Action > Action1 { get; set; }
        public LazyRow< Action > Action2 { get; set; }
        public LazyRow< Action > Action3 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            BNPC = new LazyRow< BNpcBase >( gameData, parser.ReadColumn< ushort >( 0 ), language );
            Near = parser.ReadColumn< sbyte >( 1 );
            Far = parser.ReadColumn< sbyte >( 2 );
            Angle = parser.ReadColumn< ushort >( 3 );
            Bullet = parser.ReadColumn< byte >( 4 );
            Unknown5 = parser.ReadColumn< byte >( 5 );
            Unknown6 = parser.ReadColumn< byte >( 6 );
            Action0 = new LazyRow< Action >( gameData, parser.ReadColumn< ushort >( 7 ), language );
            Action1 = new LazyRow< Action >( gameData, parser.ReadColumn< ushort >( 8 ), language );
            Action2 = new LazyRow< Action >( gameData, parser.ReadColumn< ushort >( 9 ), language );
            Action3 = new LazyRow< Action >( gameData, parser.ReadColumn< ushort >( 10 ), language );
        }
    }
}