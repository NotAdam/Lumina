// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CompanyAction", columnHash: 0xde0dd9cf )]
    public class CompanyAction : ExcelRow
    {
        
        public SeString Name;
        public SeString Description;
        public int Icon;
        public LazyRow< FCRank > FCRank;
        public uint Cost;
        public byte Order;
        public bool Purchasable;
        

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