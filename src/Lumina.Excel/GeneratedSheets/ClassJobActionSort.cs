// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ClassJobActionSort", columnHash: 0x6df8eab8 )]
    public partial class ClassJobActionSort : ExcelRow
    {
        
        public uint Unknown0 { get; set; }
        public uint Unknown1 { get; set; }
        public ushort Unknown2 { get; set; }
        public bool Unknown3 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< uint >( 0 );
            Unknown1 = parser.ReadColumn< uint >( 1 );
            Unknown2 = parser.ReadColumn< ushort >( 2 );
            Unknown3 = parser.ReadColumn< bool >( 3 );
        }
    }
}