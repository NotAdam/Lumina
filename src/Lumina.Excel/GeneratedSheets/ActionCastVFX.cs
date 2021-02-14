// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ActionCastVFX", columnHash: 0xd870e208 )]
    public class ActionCastVFX : ExcelRow
    {
        
        public LazyRow< VFX > VFX;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            VFX = new LazyRow< VFX >( lumina, parser.ReadColumn< ushort >( 0 ), language );
        }
    }
}