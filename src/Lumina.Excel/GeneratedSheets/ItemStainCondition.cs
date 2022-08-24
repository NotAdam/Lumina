// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ItemStainCondition", columnHash: 0xdbf43666 )]
    public partial class ItemStainCondition : ExcelRow
    {
        
        public uint Unknown0 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< uint >( 0 );
        }
    }
}