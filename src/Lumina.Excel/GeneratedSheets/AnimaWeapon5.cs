// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "AnimaWeapon5", columnHash: 0xe777b7a6 )]
    public partial class AnimaWeapon5 : ExcelRow
    {
        
        public LazyRow< Item > Item { get; set; }
        public byte Unknown1 { get; set; }
        public byte SecondaryStatTotal { get; set; }
        public LazyRow< AnimaWeapon5Param >[] Parameter { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Item = new LazyRow< Item >( gameData, parser.ReadColumn< int >( 0 ), language );
            Unknown1 = parser.ReadColumn< byte >( 1 );
            SecondaryStatTotal = parser.ReadColumn< byte >( 2 );
            Parameter = new LazyRow< AnimaWeapon5Param >[ 5 ];
            for( var i = 0; i < 5; i++ )
                Parameter[ i ] = new LazyRow< AnimaWeapon5Param >( gameData, parser.ReadColumn< byte >( 3 + i ), language );
        }
    }
}