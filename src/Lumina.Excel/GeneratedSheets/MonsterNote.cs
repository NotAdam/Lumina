// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MonsterNote", columnHash: 0x50b4cd8f )]
    public class MonsterNote : IExcelRow
    {
        
        public LazyRow< MonsterNoteTarget >[] MonsterNoteTarget;
        public byte[] Count;
        public uint Reward;
        public SeString Name;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            MonsterNoteTarget = new LazyRow< MonsterNoteTarget >[ 4 ];
            for( var i = 0; i < 4; i++ )
                MonsterNoteTarget[ i ] = new LazyRow< MonsterNoteTarget >( lumina, parser.ReadColumn< ushort >( 0 + i ), language );
            Count = new byte[ 4 ];
            for( var i = 0; i < 4; i++ )
                Count[ i ] = parser.ReadColumn< byte >( 4 + i );
            Reward = parser.ReadColumn< uint >( 8 );
            Name = parser.ReadColumn< SeString >( 9 );
        }
    }
}