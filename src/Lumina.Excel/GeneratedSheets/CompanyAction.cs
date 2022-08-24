// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CompanyAction", columnHash: 0xde0dd9cf )]
    public partial class CompanyAction : ExcelRow
    {
        
        public SeString Name { get; set; }
        public SeString Description { get; set; }
        public int Icon { get; set; }
        public LazyRow< FCRank > FCRank { get; set; }
        public uint Cost { get; set; }
        public byte Order { get; set; }
        public bool Purchasable { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Name = parser.ReadColumn< SeString >( 0 );
            Description = parser.ReadColumn< SeString >( 1 );
            Icon = parser.ReadColumn< int >( 2 );
            FCRank = new LazyRow< FCRank >( gameData, parser.ReadColumn< byte >( 3 ), language );
            Cost = parser.ReadColumn< uint >( 4 );
            Order = parser.ReadColumn< byte >( 5 );
            Purchasable = parser.ReadColumn< bool >( 6 );
        }
    }
}