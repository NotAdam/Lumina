// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DpsChallenge", columnHash: 0x944cf024 )]
    public class DpsChallenge : ExcelRow
    {
        
        public ushort PlayerLevel;
        public LazyRow< PlaceName > PlaceName;
        public uint Icon;
        public ushort Order;
        public SeString Name;
        public SeString Description;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            PlayerLevel = parser.ReadColumn< ushort >( 0 );
            PlaceName = new LazyRow< PlaceName >( lumina, parser.ReadColumn< ushort >( 1 ), language );
            Icon = parser.ReadColumn< uint >( 2 );
            Order = parser.ReadColumn< ushort >( 3 );
            Name = parser.ReadColumn< SeString >( 4 );
            Description = parser.ReadColumn< SeString >( 5 );
        }
    }
}