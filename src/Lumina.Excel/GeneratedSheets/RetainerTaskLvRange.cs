// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "RetainerTaskLvRange", columnHash: 0xde74b4c4 )]
    public partial class RetainerTaskLvRange : ExcelRow
    {
        
        public byte Min { get; set; }
        public byte Max { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Min = parser.ReadColumn< byte >( 0 );
            Max = parser.ReadColumn< byte >( 1 );
        }
    }
}