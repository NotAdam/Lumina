// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DeepDungeonMap5X", columnHash: 0x64a88f98 )]
    public class DeepDungeonMap5X : ExcelRow
    {
        
        public LazyRow< DeepDungeonRoom >[] DeepDungeonRoom;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            DeepDungeonRoom = new LazyRow< DeepDungeonRoom >[ 5 ];
            for( var i = 0; i < 5; i++ )
                DeepDungeonRoom[ i ] = new LazyRow< DeepDungeonRoom >( lumina, parser.ReadColumn< ushort >( 0 + i ), language );
        }
    }
}