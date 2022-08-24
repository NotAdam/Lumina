// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GuidePage", columnHash: 0x5bfa8a4e )]
    public partial class GuidePage : ExcelRow
    {
        
        public byte Key { get; set; }
        public uint Output { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Key = parser.ReadColumn< byte >( 0 );
            Output = parser.ReadColumn< uint >( 1 );
        }
    }
}