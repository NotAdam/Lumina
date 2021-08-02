// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CutScreenImage", columnHash: 0xe4a523cd )]
    public partial class CutScreenImage : ExcelRow
    {
        
        public short Type { get; set; }
        public int Image { get; set; }
        public short Unknown2 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Type = parser.ReadColumn< short >( 0 );
            Image = parser.ReadColumn< int >( 1 );
            Unknown2 = parser.ReadColumn< short >( 2 );
        }
    }
}