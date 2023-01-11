// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HWDSharedGroupControlParam", columnHash: 0xde74b4c4 )]
    public partial class HWDSharedGroupControlParam : ExcelRow
    {
        
        public byte Unknown0 { get; set; }
        public byte ParamValue { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< byte >( 0 );
            ParamValue = parser.ReadColumn< byte >( 1 );
        }
    }
}