// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "PetAction", columnHash: 0x5e492849 )]
    public partial class PetAction : ExcelRow
    {
        
        public SeString Name { get; set; }
        public SeString Description { get; set; }
        public int Icon { get; set; }
        public LazyRow< Action > Action { get; set; }
        public LazyRow< Pet > Pet { get; set; }
        public bool MasterOrder { get; set; }
        public bool DisableOrder { get; set; }
        public bool Unknown7 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Name = parser.ReadColumn< SeString >( 0 );
            Description = parser.ReadColumn< SeString >( 1 );
            Icon = parser.ReadColumn< int >( 2 );
            Action = new LazyRow< Action >( gameData, parser.ReadColumn< ushort >( 3 ), language );
            Pet = new LazyRow< Pet >( gameData, parser.ReadColumn< byte >( 4 ), language );
            MasterOrder = parser.ReadColumn< bool >( 5 );
            DisableOrder = parser.ReadColumn< bool >( 6 );
            Unknown7 = parser.ReadColumn< bool >( 7 );
        }
    }
}