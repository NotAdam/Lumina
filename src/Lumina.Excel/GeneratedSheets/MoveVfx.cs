// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MoveVfx", columnHash: 0x2020acf6 )]
    public class MoveVfx : ExcelRow
    {
        
        public LazyRow< VFX > VFXNormal;
        public LazyRow< VFX > VFXWalking;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            VFXNormal = new LazyRow< VFX >( lumina, parser.ReadColumn< ushort >( 0 ), language );
            VFXWalking = new LazyRow< VFX >( lumina, parser.ReadColumn< ushort >( 1 ), language );
        }
    }
}