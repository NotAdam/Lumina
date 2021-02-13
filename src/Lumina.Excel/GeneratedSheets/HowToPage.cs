// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HowToPage", columnHash: 0x006e1eac )]
    public class HowToPage : ExcelRow
    {
        
        public byte Unknown0;
        public byte Unknown1;
        public int Image;
        public byte Unknown3;
        public SeString Unknown4;
        public SeString Unknown5;
        public SeString Unknown6;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Unknown0 = parser.ReadColumn< byte >( 0 );
            Unknown1 = parser.ReadColumn< byte >( 1 );
            Image = parser.ReadColumn< int >( 2 );
            Unknown3 = parser.ReadColumn< byte >( 3 );
            Unknown4 = parser.ReadColumn< SeString >( 4 );
            Unknown5 = parser.ReadColumn< SeString >( 5 );
            Unknown6 = parser.ReadColumn< SeString >( 6 );
        }
    }
}