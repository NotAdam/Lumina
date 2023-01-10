// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "StanceChange", columnHash: 0xf31cad82 )]
    public partial class StanceChange : ExcelRow
    {
        
        public ushort Unknown0 { get; set; }
        public LazyRow< Action >[] Action { get; set; }
        public ushort Unknown3 { get; set; }
        public float Unknown4 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< ushort >( 0 );
            Action = new LazyRow< Action >[ 2 ];
            for( var i = 0; i < 2; i++ )
                Action[ i ] = new LazyRow< Action >( gameData, parser.ReadColumn< ushort >( 1 + i ), language );
            Unknown3 = parser.ReadColumn< ushort >( 3 );
            Unknown4 = parser.ReadColumn< float >( 4 );
        }
    }
}