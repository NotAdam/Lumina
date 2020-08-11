// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HowTo", columnHash: 0xe4488448 )]
    public class HowTo : IExcelRow
    {
        
        public string Unknown0;
        public bool Unknown1;
        public LazyRow< HowToPage >[] Images;
        public LazyRow< HowToCategory > Category;
        public byte Unknown13;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Unknown0 = parser.ReadColumn< string >( 0 );
            Unknown1 = parser.ReadColumn< bool >( 1 );
            Images = new LazyRow< HowToPage >[ 10 ];
            for( var i = 0; i < 10; i++ )
                Images[ i ] = new LazyRow< HowToPage >( lumina, parser.ReadColumn< short >( 2 + i ), language );
            Category = new LazyRow< HowToCategory >( lumina, parser.ReadColumn< sbyte >( 12 ), language );
            Unknown13 = parser.ReadColumn< byte >( 13 );
        }
    }
}