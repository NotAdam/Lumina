// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Materia", columnHash: 0xa10c6ac0 )]
    public class Materia : IExcelRow
    {
        
        public LazyRow< Item >[] Item;
        public LazyRow< BaseParam > BaseParam;
        public short[] Value;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Item = new LazyRow< Item >[ 10 ];
            for( var i = 0; i < 10; i++ )
                Item[ i ] = new LazyRow< Item >( lumina, parser.ReadColumn< int >( 0 + i ), language );
            BaseParam = new LazyRow< BaseParam >( lumina, parser.ReadColumn< byte >( 10 ), language );
            Value = new short[ 10 ];
            for( var i = 0; i < 10; i++ )
                Value[ i ] = parser.ReadColumn< short >( 11 + i );
        }
    }
}