// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "FCCrestSymbol", columnHash: 0x43bdd5b1 )]
    public class FCCrestSymbol : ExcelRow
    {
        
        public byte ColorNum;
        public byte FCRight;
        public ushort Unknown2;
        

        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            ColorNum = parser.ReadColumn< byte >( 0 );
            FCRight = parser.ReadColumn< byte >( 1 );
            Unknown2 = parser.ReadColumn< ushort >( 2 );
        }
    }
}