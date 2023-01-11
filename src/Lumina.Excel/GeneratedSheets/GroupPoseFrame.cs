// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GroupPoseFrame", columnHash: 0x1771561e )]
    public partial class GroupPoseFrame : ExcelRow
    {
        
        public int Unknown0 { get; set; }
        public int Image { get; set; }
        public SeString GridText { get; set; }
        public int Unknown3 { get; set; }
        public uint Unknown4 { get; set; }
        public byte Unknown5 { get; set; }
        public int Unknown6 { get; set; }
        public SeString Text { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< int >( 0 );
            Image = parser.ReadColumn< int >( 1 );
            GridText = parser.ReadColumn< SeString >( 2 );
            Unknown3 = parser.ReadColumn< int >( 3 );
            Unknown4 = parser.ReadColumn< uint >( 4 );
            Unknown5 = parser.ReadColumn< byte >( 5 );
            Unknown6 = parser.ReadColumn< int >( 6 );
            Text = parser.ReadColumn< SeString >( 7 );
        }
    }
}