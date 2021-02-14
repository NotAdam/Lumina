// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ContentRouletteOpenRule", columnHash: 0x985449ce )]
    public class ContentRouletteOpenRule : ExcelRow
    {
        
        public bool Unknown0;
        public uint Type;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Unknown0 = parser.ReadColumn< bool >( 0 );
            Type = parser.ReadColumn< uint >( 1 );
        }
    }
}