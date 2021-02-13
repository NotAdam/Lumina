// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MateriaTomestoneRate", columnHash: 0xdbf43666 )]
    public class MateriaTomestoneRate : ExcelRow
    {
        
        public uint Rate;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Rate = parser.ReadColumn< uint >( 0 );
        }
    }
}