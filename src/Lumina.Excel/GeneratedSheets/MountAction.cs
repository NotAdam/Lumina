// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MountAction", columnHash: 0x58822da3 )]
    public class MountAction : ExcelRow
    {
        
        public LazyRow< Action >[] Action;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Action = new LazyRow< Action >[ 6 ];
            for( var i = 0; i < 6; i++ )
                Action[ i ] = new LazyRow< Action >( lumina, parser.ReadColumn< ushort >( 0 + i ), language );
        }
    }
}