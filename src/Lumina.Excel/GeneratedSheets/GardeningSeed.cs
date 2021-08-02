// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GardeningSeed", columnHash: 0xa8a6cb9c )]
    public partial class GardeningSeed : ExcelRow
    {
        
        public LazyRow< Item > Item { get; set; }
        public ushort ModelID { get; set; }
        public uint Icon { get; set; }
        public bool SE { get; set; }
        public bool Unknown4 { get; set; }
        public byte Unknown5 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Item = new LazyRow< Item >( gameData, parser.ReadColumn< uint >( 0 ), language );
            ModelID = parser.ReadColumn< ushort >( 1 );
            Icon = parser.ReadColumn< uint >( 2 );
            SE = parser.ReadColumn< bool >( 3 );
            Unknown4 = parser.ReadColumn< bool >( 4 );
            Unknown5 = parser.ReadColumn< byte >( 5 );
        }
    }
}