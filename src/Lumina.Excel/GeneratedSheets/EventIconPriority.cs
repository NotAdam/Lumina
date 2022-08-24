// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "EventIconPriority", columnHash: 0xf16871d0 )]
    public partial class EventIconPriority : ExcelRow
    {
        
        public uint[] Icon { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Icon = new uint[ 19 ];
            for( var i = 0; i < 19; i++ )
                Icon[ i ] = parser.ReadColumn< uint >( 0 + i );
        }
    }
}