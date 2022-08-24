// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ContentGaugeColor", columnHash: 0x96a22aea )]
    public partial class ContentGaugeColor : ExcelRow
    {
        
        public uint AndroidColor1 { get; set; }
        public uint AndroidColor2 { get; set; }
        public uint AndroidColor3 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            AndroidColor1 = parser.ReadColumn< uint >( 0 );
            AndroidColor2 = parser.ReadColumn< uint >( 1 );
            AndroidColor3 = parser.ReadColumn< uint >( 2 );
        }
    }
}