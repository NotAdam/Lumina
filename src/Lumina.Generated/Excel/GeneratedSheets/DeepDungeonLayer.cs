using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DeepDungeonLayer", columnHash: 0x832a5a83 )]
    public class DeepDungeonLayer : IExcelRow
    {
        
        public LazyRow< DeepDungeon > DeepDungeon;
        public byte Unknown1;
        public ushort Unknown2;
        public ushort Unknown3;
        public ushort Unknown4;
        public byte Unknown5;
        public byte Unknown6;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            DeepDungeon = new LazyRow< DeepDungeon >( lumina, parser.ReadColumn< byte >( 0 ), language );
            Unknown1 = parser.ReadColumn< byte >( 1 );
            Unknown2 = parser.ReadColumn< ushort >( 2 );
            Unknown3 = parser.ReadColumn< ushort >( 3 );
            Unknown4 = parser.ReadColumn< ushort >( 4 );
            Unknown5 = parser.ReadColumn< byte >( 5 );
            Unknown6 = parser.ReadColumn< byte >( 6 );
        }
    }
}