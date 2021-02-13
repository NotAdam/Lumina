// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "SpearfishingRecordPage", columnHash: 0x4f78acda )]
    public class SpearfishingRecordPage : ExcelRow
    {
        
        public byte Unknown0;
        public byte Unknown1;
        public byte Unknown2;
        public LazyRow< PlaceName > PlaceName;
        public int Image;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Unknown0 = parser.ReadColumn< byte >( 0 );
            Unknown1 = parser.ReadColumn< byte >( 1 );
            Unknown2 = parser.ReadColumn< byte >( 2 );
            PlaceName = new LazyRow< PlaceName >( lumina, parser.ReadColumn< int >( 3 ), language );
            Image = parser.ReadColumn< int >( 4 );
        }
    }
}