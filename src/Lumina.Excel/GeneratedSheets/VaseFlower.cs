// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "VaseFlower", columnHash: 0x8c05af34 )]
    public class VaseFlower : ExcelRow
    {
        
        public ushort Unknown0;
        public byte Unknown1;
        public byte Unknown2;
        public LazyRow< Item > Item;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Unknown0 = parser.ReadColumn< ushort >( 0 );
            Unknown1 = parser.ReadColumn< byte >( 1 );
            Unknown2 = parser.ReadColumn< byte >( 2 );
            Item = new LazyRow< Item >( lumina, parser.ReadColumn< uint >( 3 ), language );
        }
    }
}