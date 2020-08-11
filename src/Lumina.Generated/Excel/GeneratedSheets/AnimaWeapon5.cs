// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "AnimaWeapon5", columnHash: 0xe777b7a6 )]
    public class AnimaWeapon5 : IExcelRow
    {
        
        public LazyRow< Item > Item;
        public byte Unknown1;
        public byte SecondaryStatTotal;
        public LazyRow< AnimaWeapon5Param >[] Parameter;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Item = new LazyRow< Item >( lumina, parser.ReadColumn< int >( 0 ), language );
            Unknown1 = parser.ReadColumn< byte >( 1 );
            SecondaryStatTotal = parser.ReadColumn< byte >( 2 );
            Parameter = new LazyRow< AnimaWeapon5Param >[ 5 ];
            for( var i = 0; i < 5; i++ )
                Parameter[ i ] = new LazyRow< AnimaWeapon5Param >( lumina, parser.ReadColumn< byte >( 3 + i ), language );
        }
    }
}