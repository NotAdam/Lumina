// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CraftType", columnHash: 0xb92c9b70 )]
    public partial class CraftType : ExcelRow
    {
        
        public byte MainPhysical { get; set; }
        public byte SubPhysical { get; set; }
        public SeString Name { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            MainPhysical = parser.ReadColumn< byte >( 0 );
            SubPhysical = parser.ReadColumn< byte >( 1 );
            Name = parser.ReadColumn< SeString >( 2 );
        }
    }
}