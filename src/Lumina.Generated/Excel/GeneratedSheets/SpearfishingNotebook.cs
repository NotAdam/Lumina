// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "SpearfishingNotebook", columnHash: 0x0f196a4a )]
    public class SpearfishingNotebook : IExcelRow
    {
        
        public byte GatheringLevel;
        public bool Unknown1;
        public LazyRow< TerritoryType > TerritoryType;
        public short X;
        public short Y;
        public ushort Radius;
        public byte Unknown6;
        public LazyRow< PlaceName > PlaceName;
        public byte Unknown8;
        public LazyRow< GatheringPointBase > GatheringPointBase;
        public ushort Unknown10;
        public ushort Unknown11;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            GatheringLevel = parser.ReadColumn< byte >( 0 );
            Unknown1 = parser.ReadColumn< bool >( 1 );
            TerritoryType = new LazyRow< TerritoryType >( lumina, parser.ReadColumn< int >( 2 ), language );
            X = parser.ReadColumn< short >( 3 );
            Y = parser.ReadColumn< short >( 4 );
            Radius = parser.ReadColumn< ushort >( 5 );
            Unknown6 = parser.ReadColumn< byte >( 6 );
            PlaceName = new LazyRow< PlaceName >( lumina, parser.ReadColumn< ushort >( 7 ), language );
            Unknown8 = parser.ReadColumn< byte >( 8 );
            GatheringPointBase = new LazyRow< GatheringPointBase >( lumina, parser.ReadColumn< ushort >( 9 ), language );
            Unknown10 = parser.ReadColumn< ushort >( 10 );
            Unknown11 = parser.ReadColumn< ushort >( 11 );
        }
    }
}