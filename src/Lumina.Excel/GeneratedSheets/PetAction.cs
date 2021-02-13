// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "PetAction", columnHash: 0x5e492849 )]
    public class PetAction : ExcelRow
    {
        
        public SeString Name;
        public SeString Description;
        public int Icon;
        public LazyRow< Action > Action;
        public LazyRow< Pet > Pet;
        public bool MasterOrder;
        public bool DisableOrder;
        public bool Unknown7;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Name = parser.ReadColumn< SeString >( 0 );
            Description = parser.ReadColumn< SeString >( 1 );
            Icon = parser.ReadColumn< int >( 2 );
            Action = new LazyRow< Action >( lumina, parser.ReadColumn< ushort >( 3 ), language );
            Pet = new LazyRow< Pet >( lumina, parser.ReadColumn< byte >( 4 ), language );
            MasterOrder = parser.ReadColumn< bool >( 5 );
            DisableOrder = parser.ReadColumn< bool >( 6 );
            Unknown7 = parser.ReadColumn< bool >( 7 );
        }
    }
}