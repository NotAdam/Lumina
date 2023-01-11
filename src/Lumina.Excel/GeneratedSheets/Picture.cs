// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Picture", columnHash: 0xfaedad07 )]
    public partial class Picture : ExcelRow
    {
        
        public int Image { get; set; }
        public int Signature { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Image = parser.ReadColumn< int >( 0 );
            Signature = parser.ReadColumn< int >( 1 );
        }
    }
}