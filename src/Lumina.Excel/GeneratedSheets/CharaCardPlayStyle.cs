// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CharaCardPlayStyle", columnHash: 0x30ebf383 )]
    public class CharaCardPlayStyle : ExcelRow
    {
        
        public int Unknown0 { get; set; }
        public byte Unknown1 { get; set; }
        public SeString Unknown2 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< int >( 0 );
            Unknown1 = parser.ReadColumn< byte >( 1 );
            Unknown2 = parser.ReadColumn< SeString >( 2 );
        }
    }
}