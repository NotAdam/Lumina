// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ArchiveItem", columnHash: 0x31b3477e )]
    public partial class ArchiveItem : ExcelRow
    {
        
        public int Unknown0 { get; set; }
        public ushort Unknown1 { get; set; }
        public bool Unknown2 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< int >( 0 );
            Unknown1 = parser.ReadColumn< ushort >( 1 );
            Unknown2 = parser.ReadColumn< bool >( 2 );
        }
    }
}