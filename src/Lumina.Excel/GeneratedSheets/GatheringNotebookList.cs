// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GatheringNotebookList", columnHash: 0x1da7bb26 )]
    public class GatheringNotebookList : ExcelRow
    {
        
        public byte Unknown0;
        public LazyRow< GatheringItem >[] GatheringItem;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Unknown0 = parser.ReadColumn< byte >( 0 );
            GatheringItem = new LazyRow< GatheringItem >[ 100 ];
            for( var i = 0; i < 100; i++ )
                GatheringItem[ i ] = new LazyRow< GatheringItem >( lumina, parser.ReadColumn< int >( 1 + i ), language );
        }
    }
}