// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "SharlayanCraftWorks", columnHash: 0x92b51979 )]
    public partial class SharlayanCraftWorks : ExcelRow
    {
        
        public uint Unknown0 { get; set; }
        public ushort Unknown1 { get; set; }
        public SeString Unknown2 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< uint >( 0 );
            Unknown1 = parser.ReadColumn< ushort >( 1 );
            Unknown2 = parser.ReadColumn< SeString >( 2 );
        }
    }
}