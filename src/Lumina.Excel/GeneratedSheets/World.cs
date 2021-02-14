// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "World", columnHash: 0xd4d62b80 )]
    public class World : ExcelRow
    {
        
        public SeString Name;
        public byte UserType;
        public LazyRow< WorldDCGroupType > DataCenter;
        public bool IsPublic;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Name = parser.ReadColumn< SeString >( 0 );
            UserType = parser.ReadColumn< byte >( 1 );
            DataCenter = new LazyRow< WorldDCGroupType >( lumina, parser.ReadColumn< byte >( 2 ), language );
            IsPublic = parser.ReadColumn< bool >( 3 );
        }
    }
}