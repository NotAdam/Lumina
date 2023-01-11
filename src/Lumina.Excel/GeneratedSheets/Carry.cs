// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Carry", columnHash: 0x31e1f9e6 )]
    public partial class Carry : ExcelRow
    {
        
        public ulong Model { get; set; }
        public byte Timeline { get; set; }
        public byte Unknown2 { get; set; }
        public byte Unknown3 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Model = parser.ReadColumn< ulong >( 0 );
            Timeline = parser.ReadColumn< byte >( 1 );
            Unknown2 = parser.ReadColumn< byte >( 2 );
            Unknown3 = parser.ReadColumn< byte >( 3 );
        }
    }
}