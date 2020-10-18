// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DeepDungeonMap5X", columnHash: 0x64a88f98 )]
    public class DeepDungeonMap5X : IExcelRow
    {
        
        public LazyRow< DeepDungeonRoom >[] DeepDungeonRoom;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            DeepDungeonRoom = new LazyRow< DeepDungeonRoom >[ 5 ];
            for( var i = 0; i < 5; i++ )
                DeepDungeonRoom[ i ] = new LazyRow< DeepDungeonRoom >( lumina, parser.ReadColumn< ushort >( 0 + i ), language );
        }
    }
}