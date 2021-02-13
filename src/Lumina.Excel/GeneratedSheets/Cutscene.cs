// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Cutscene", columnHash: 0x35b9ac80 )]
    public class Cutscene : ExcelRow
    {
        
        public SeString Path;
        public byte Unknown1;
        public byte Unknown2;
        public bool Unknown3;
        public int Unknown4;
        public int Unknown5;
        public int Unknown6;
        public int Unknown7;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Path = parser.ReadColumn< SeString >( 0 );
            Unknown1 = parser.ReadColumn< byte >( 1 );
            Unknown2 = parser.ReadColumn< byte >( 2 );
            Unknown3 = parser.ReadColumn< bool >( 3 );
            Unknown4 = parser.ReadColumn< int >( 4 );
            Unknown5 = parser.ReadColumn< int >( 5 );
            Unknown6 = parser.ReadColumn< int >( 6 );
            Unknown7 = parser.ReadColumn< int >( 7 );
        }
    }
}