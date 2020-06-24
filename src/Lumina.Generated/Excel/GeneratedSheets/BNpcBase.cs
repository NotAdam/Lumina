using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "BNpcBase", columnHash: 0xdd911c47 )]
    public class BNpcBase : IExcelRow
    {
        
        public LazyRow< Behavior > Behavior;
        public byte Battalion;
        public byte LinkRace;
        public byte Rank;
        public float Scale;
        public LazyRow< ModelChara > ModelChara;
        public LazyRow< BNpcCustomize > BNpcCustomize;
        public LazyRow< NpcEquip > NpcEquip;
        public ushort Special;
        public byte SEPack;
        public bool Unknown10;
        public LazyRow< ArrayEventHandler > ArrayEventHandler;
        public LazyRow< BNpcParts > BNpcParts;
        public bool Unknown13;
        public bool IsTargetLine;
        public bool IsDisplayLevel;
        public bool Unknown16;
        public bool Unknown17;
        public byte Unknown18;
        public byte Unknown19;
        public byte Unknown20;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Behavior = new LazyRow< Behavior >( lumina, parser.ReadColumn< ushort >( 0 ), language );
            Battalion = parser.ReadColumn< byte >( 1 );
            LinkRace = parser.ReadColumn< byte >( 2 );
            Rank = parser.ReadColumn< byte >( 3 );
            Scale = parser.ReadColumn< float >( 4 );
            ModelChara = new LazyRow< ModelChara >( lumina, parser.ReadColumn< ushort >( 5 ), language );
            BNpcCustomize = new LazyRow< BNpcCustomize >( lumina, parser.ReadColumn< ushort >( 6 ), language );
            NpcEquip = new LazyRow< NpcEquip >( lumina, parser.ReadColumn< ushort >( 7 ), language );
            Special = parser.ReadColumn< ushort >( 8 );
            SEPack = parser.ReadColumn< byte >( 9 );
            Unknown10 = parser.ReadColumn< bool >( 10 );
            ArrayEventHandler = new LazyRow< ArrayEventHandler >( lumina, parser.ReadColumn< int >( 11 ), language );
            BNpcParts = new LazyRow< BNpcParts >( lumina, parser.ReadColumn< byte >( 12 ), language );
            Unknown13 = parser.ReadColumn< bool >( 13 );
            IsTargetLine = parser.ReadColumn< bool >( 14 );
            IsDisplayLevel = parser.ReadColumn< bool >( 15 );
            Unknown16 = parser.ReadColumn< bool >( 16 );
            Unknown17 = parser.ReadColumn< bool >( 17 );
            Unknown18 = parser.ReadColumn< byte >( 18 );
            Unknown19 = parser.ReadColumn< byte >( 19 );
            Unknown20 = parser.ReadColumn< byte >( 20 );
        }
    }
}