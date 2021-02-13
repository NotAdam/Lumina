// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "BacklightColor", columnHash: 0xdbf43666 )]
    public class BacklightColor : ExcelRow
    {
        
        public uint Color;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Color = parser.ReadColumn< uint >( 0 );
        }
    }
}