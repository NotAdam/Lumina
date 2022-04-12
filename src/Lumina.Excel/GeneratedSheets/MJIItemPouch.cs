// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MJIItemPouch", columnHash: 0x5c9aa6b3 )]
    public class MJIItemPouch : ExcelRow
    {
        
        public uint Unknown0 { get; set; }
        public int Unknown1 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< uint >( 0 );
            Unknown1 = parser.ReadColumn< int >( 1 );
        }
    }
}