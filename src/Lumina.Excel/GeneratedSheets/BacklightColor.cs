// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "BacklightColor", columnHash: 0xdbf43666 )]
    public partial class BacklightColor : ExcelRow
    {
        
        public uint Color { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Color = parser.ReadColumn< uint >( 0 );
        }
    }
}