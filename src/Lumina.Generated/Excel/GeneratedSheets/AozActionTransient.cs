using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "AozActionTransient", columnHash: 0x4921bb28 )]
    public class AozActionTransient : IExcelRow
    {
        
        public byte Number;
        public uint Icon;
        public string Stats;
        public string Description;
        public byte Unknown4;
        public LazyRow< ContentFinderCondition > Location;
        public LazyRow< Quest > StartQuest;
        public LazyRow< Quest > NextQuest;
        public bool Unknown8;
        public bool Unknown9;
        public bool Unknown10;
        public bool Unknown11;
        public bool Unknown12;
        public bool Unknown13;
        public bool Unknown14;
        public bool Unknown15;
        public bool Unknown16;
        public bool Unknown17;
        public bool Unknown18;
        public bool Unknown19;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Number = parser.ReadColumn< byte >( 0 );
            Icon = parser.ReadColumn< uint >( 1 );
            Stats = parser.ReadColumn< string >( 2 );
            Description = parser.ReadColumn< string >( 3 );
            Unknown4 = parser.ReadColumn< byte >( 4 );
            Location = new LazyRow< ContentFinderCondition >( lumina, parser.ReadColumn< ushort >( 5 ) );
            StartQuest = new LazyRow< Quest >( lumina, parser.ReadColumn< uint >( 6 ) );
            NextQuest = new LazyRow< Quest >( lumina, parser.ReadColumn< uint >( 7 ) );
            Unknown8 = parser.ReadColumn< bool >( 8 );
            Unknown9 = parser.ReadColumn< bool >( 9 );
            Unknown10 = parser.ReadColumn< bool >( 10 );
            Unknown11 = parser.ReadColumn< bool >( 11 );
            Unknown12 = parser.ReadColumn< bool >( 12 );
            Unknown13 = parser.ReadColumn< bool >( 13 );
            Unknown14 = parser.ReadColumn< bool >( 14 );
            Unknown15 = parser.ReadColumn< bool >( 15 );
            Unknown16 = parser.ReadColumn< bool >( 16 );
            Unknown17 = parser.ReadColumn< bool >( 17 );
            Unknown18 = parser.ReadColumn< bool >( 18 );
            Unknown19 = parser.ReadColumn< bool >( 19 );
        }
    }
}