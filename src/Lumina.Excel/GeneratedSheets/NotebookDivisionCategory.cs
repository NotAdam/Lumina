// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "NotebookDivisionCategory", columnHash: 0x9ff65ad6 )]
    public class NotebookDivisionCategory : ExcelRow
    {
        
        public SeString Name;
        public byte Index;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Name = parser.ReadColumn< SeString >( 0 );
            Index = parser.ReadColumn< byte >( 1 );
        }
    }
}