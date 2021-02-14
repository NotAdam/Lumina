// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Channeling", columnHash: 0x8c3707e3 )]
    public class Channeling : ExcelRow
    {
        
        public SeString File;
        public byte WidthScale;
        public bool AddedIn53;
        public bool Unknown3;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            File = parser.ReadColumn< SeString >( 0 );
            WidthScale = parser.ReadColumn< byte >( 1 );
            AddedIn53 = parser.ReadColumn< bool >( 2 );
            Unknown3 = parser.ReadColumn< bool >( 3 );
        }
    }
}