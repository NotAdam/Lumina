// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ChocoboRaceTutorial", columnHash: 0xef6c7b71 )]
    public class ChocoboRaceTutorial : IExcelRow
    {
        
        public LazyRow< NpcYell >[] NpcYell;
        public ushort Unknown8;
        public ushort Unknown9;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            NpcYell = new LazyRow< NpcYell >[ 8 ];
            for( var i = 0; i < 8; i++ )
                NpcYell[ i ] = new LazyRow< NpcYell >( lumina, parser.ReadColumn< int >( 0 + i ), language );
            Unknown8 = parser.ReadColumn< ushort >( 8 );
            Unknown9 = parser.ReadColumn< ushort >( 9 );
        }
    }
}