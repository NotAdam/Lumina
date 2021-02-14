// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "RacingChocoboItem", columnHash: 0xe79dd9d4 )]
    public class RacingChocoboItem : ExcelRow
    {
        
        public LazyRow< Item > Item;
        public byte Category;
        public byte[] Param;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Item = new LazyRow< Item >( lumina, parser.ReadColumn< int >( 0 ), language );
            Category = parser.ReadColumn< byte >( 1 );
            Param = new byte[ 2 ];
            for( var i = 0; i < 2; i++ )
                Param[ i ] = parser.ReadColumn< byte >( 2 + i );
        }
    }
}