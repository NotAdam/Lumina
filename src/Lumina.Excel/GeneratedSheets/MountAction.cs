// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MountAction", columnHash: 0x58822da3 )]
    public partial class MountAction : ExcelRow
    {
        
        public LazyRow< Action >[] Action { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Action = new LazyRow< Action >[ 6 ];
            for( var i = 0; i < 6; i++ )
                Action[ i ] = new LazyRow< Action >( gameData, parser.ReadColumn< ushort >( 0 + i ), language );
        }
    }
}