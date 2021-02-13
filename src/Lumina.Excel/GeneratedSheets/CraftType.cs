// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CraftType", columnHash: 0xb92c9b70 )]
    public class CraftType : ExcelRow
    {
        
        public byte MainPhysical;
        public byte SubPhysical;
        public SeString Name;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            MainPhysical = parser.ReadColumn< byte >( 0 );
            SubPhysical = parser.ReadColumn< byte >( 1 );
            Name = parser.ReadColumn< SeString >( 2 );
        }
    }
}