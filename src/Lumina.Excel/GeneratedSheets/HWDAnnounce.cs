// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HWDAnnounce", columnHash: 0x1d91a784 )]
    public class HWDAnnounce : ExcelRow
    {
        
        public SeString Name;
        public LazyRow< ENpcResident > ENPC;
        public byte Unknown2;
        public byte Unknown3;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Name = parser.ReadColumn< SeString >( 0 );
            ENPC = new LazyRow< ENpcResident >( lumina, parser.ReadColumn< uint >( 1 ), language );
            Unknown2 = parser.ReadColumn< byte >( 2 );
            Unknown3 = parser.ReadColumn< byte >( 3 );
        }
    }
}