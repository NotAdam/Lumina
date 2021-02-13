// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GatheringType", columnHash: 0x182c5eea )]
    public class GatheringType : ExcelRow
    {
        
        public SeString Name;
        public int IconMain;
        public int IconOff;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Name = parser.ReadColumn< SeString >( 0 );
            IconMain = parser.ReadColumn< int >( 1 );
            IconOff = parser.ReadColumn< int >( 2 );
        }
    }
}