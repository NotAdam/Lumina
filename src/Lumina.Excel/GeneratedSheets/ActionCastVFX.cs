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
        

        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            VFX = new LazyRow< VFX >( gameData, parser.ReadColumn< ushort >( 0 ), language );
        }
    }
}