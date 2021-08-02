// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Lobby", columnHash: 0x54075f2e )]
    public partial class Lobby : ExcelRow
    {
        
        public uint TYPE { get; set; }
        public uint PARAM { get; set; }
        public uint LINK { get; set; }
        public SeString Text { get; set; }
        public SeString Unknown4 { get; set; }
        public SeString Unknown5 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            TYPE = parser.ReadColumn< uint >( 0 );
            PARAM = parser.ReadColumn< uint >( 1 );
            LINK = parser.ReadColumn< uint >( 2 );
            Text = parser.ReadColumn< SeString >( 3 );
            Unknown4 = parser.ReadColumn< SeString >( 4 );
            Unknown5 = parser.ReadColumn< SeString >( 5 );
        }
    }
}