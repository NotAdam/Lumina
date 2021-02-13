// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "SubmarineMap", columnHash: 0x98fff20a )]
    public class SubmarineMap : ExcelRow
    {
        
        public SeString Name;
        public uint Image;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Name = parser.ReadColumn< SeString >( 0 );
            Image = parser.ReadColumn< uint >( 1 );
        }
    }
}