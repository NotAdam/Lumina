// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MJIFunction", columnHash: 0x3264a656 )]
    public class MJIFunction : ExcelRow
    {
        
        public sbyte Unknown0 { get; set; }
        public byte Unknown1 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< sbyte >( 0 );
            Unknown1 = parser.ReadColumn< byte >( 1 );
        }
    }
}