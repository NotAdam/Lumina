// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MJIMinionPopAreas", columnHash: 0xca8d8231 )]
    public partial class MJIMinionPopAreas : ExcelRow
    {
        
        public byte Unknown0 { get; set; }
        public short Unknown1 { get; set; }
        public short Unknown2 { get; set; }
        public int Unknown3 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< byte >( 0 );
            Unknown1 = parser.ReadColumn< short >( 1 );
            Unknown2 = parser.ReadColumn< short >( 2 );
            Unknown3 = parser.ReadColumn< int >( 3 );
        }
    }
}