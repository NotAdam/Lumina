using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "SkyIsland2MissionDetail", columnHash: 0x62246edb )]
    public class SkyIsland2MissionDetail : IExcelRow
    {
        
        public LazyRow< SkyIsland2MissionType > Type;
        public byte Unknown1;
        public LazyRow< SkyIsland2RangeType > Range;
        public sbyte Unknown3;
        public LazyRow< EObjName > EObj;
        public uint Unknown5;
        public uint Unknown6;
        public string Objective;
        public string Unknown8;
        public string Unknown9;
        public string Unknown10;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Type = new LazyRow< SkyIsland2MissionType >( lumina, parser.ReadColumn< byte >( 0 ), language );
            Unknown1 = parser.ReadColumn< byte >( 1 );
            Range = new LazyRow< SkyIsland2RangeType >( lumina, parser.ReadColumn< byte >( 2 ), language );
            Unknown3 = parser.ReadColumn< sbyte >( 3 );
            EObj = new LazyRow< EObjName >( lumina, parser.ReadColumn< uint >( 4 ), language );
            Unknown5 = parser.ReadColumn< uint >( 5 );
            Unknown6 = parser.ReadColumn< uint >( 6 );
            Objective = parser.ReadColumn< string >( 7 );
            Unknown8 = parser.ReadColumn< string >( 8 );
            Unknown9 = parser.ReadColumn< string >( 9 );
            Unknown10 = parser.ReadColumn< string >( 10 );
        }
    }
}