using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ZoneSharedGroup", columnHash: 0x7795f6ea )]
    public class ZoneSharedGroup : IExcelRow
    {
        
        public uint Unknown0;
        public byte Unknown1;
        public LazyRow< Quest > Quest1;
        public uint Unknown3;
        public bool Unknown4;
        public byte Unknown5;
        public LazyRow< Quest > Quest2;
        public uint Unknown7;
        public bool Unknown8;
        public byte Unknown9;
        public LazyRow< Quest > Quest3;
        public uint Unknown11;
        public bool Unknown12;
        public byte Unknown13;
        public LazyRow< Quest > Quest4;
        public uint Unknown15;
        public bool Unknown16;
        public byte Unknown17;
        public LazyRow< Quest > Quest5;
        public uint Unknown19;
        public bool Unknown20;
        public byte Unknown21;
        public LazyRow< Quest > Quest6;
        public uint Unknown23;
        public bool Unknown24;
        public byte Unknown25;
        public uint Unknown26;
        public uint Unknown27;
        public bool Unknown28;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Unknown0 = parser.ReadColumn< uint >( 0 );
            Unknown1 = parser.ReadColumn< byte >( 1 );
            Quest1 = new LazyRow< Quest >( lumina, parser.ReadColumn< uint >( 2 ), language );
            Unknown3 = parser.ReadColumn< uint >( 3 );
            Unknown4 = parser.ReadColumn< bool >( 4 );
            Unknown5 = parser.ReadColumn< byte >( 5 );
            Quest2 = new LazyRow< Quest >( lumina, parser.ReadColumn< uint >( 6 ), language );
            Unknown7 = parser.ReadColumn< uint >( 7 );
            Unknown8 = parser.ReadColumn< bool >( 8 );
            Unknown9 = parser.ReadColumn< byte >( 9 );
            Quest3 = new LazyRow< Quest >( lumina, parser.ReadColumn< uint >( 10 ), language );
            Unknown11 = parser.ReadColumn< uint >( 11 );
            Unknown12 = parser.ReadColumn< bool >( 12 );
            Unknown13 = parser.ReadColumn< byte >( 13 );
            Quest4 = new LazyRow< Quest >( lumina, parser.ReadColumn< uint >( 14 ), language );
            Unknown15 = parser.ReadColumn< uint >( 15 );
            Unknown16 = parser.ReadColumn< bool >( 16 );
            Unknown17 = parser.ReadColumn< byte >( 17 );
            Quest5 = new LazyRow< Quest >( lumina, parser.ReadColumn< uint >( 18 ), language );
            Unknown19 = parser.ReadColumn< uint >( 19 );
            Unknown20 = parser.ReadColumn< bool >( 20 );
            Unknown21 = parser.ReadColumn< byte >( 21 );
            Quest6 = new LazyRow< Quest >( lumina, parser.ReadColumn< uint >( 22 ), language );
            Unknown23 = parser.ReadColumn< uint >( 23 );
            Unknown24 = parser.ReadColumn< bool >( 24 );
            Unknown25 = parser.ReadColumn< byte >( 25 );
            Unknown26 = parser.ReadColumn< uint >( 26 );
            Unknown27 = parser.ReadColumn< uint >( 27 );
            Unknown28 = parser.ReadColumn< bool >( 28 );
        }
    }
}