// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "EurekaSphereElementAdjust", columnHash: 0xd870e208 )]
    public class EurekaSphereElementAdjust : ExcelRow
    {
        
        public ushort PowerModifier;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            PowerModifier = parser.ReadColumn< ushort >( 0 );
        }
    }
}