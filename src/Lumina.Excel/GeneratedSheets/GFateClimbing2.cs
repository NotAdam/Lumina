// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GFateClimbing2", columnHash: 0xdbf43666 )]
    public class GFateClimbing2 : ExcelRow
    {
        
        public uint ContentEntry;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            ContentEntry = parser.ReadColumn< uint >( 0 );
        }
    }
}