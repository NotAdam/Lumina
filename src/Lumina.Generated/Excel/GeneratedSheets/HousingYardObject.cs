using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HousingYardObject", columnHash: 0xe15fd4d0 )]
    public class HousingYardObject : IExcelRow
    {
        
        public byte ModelKey;
        public byte HousingItemCategory;
        public byte UsageType;
        public uint UsageParameter;
        public byte Unknown4;
        public LazyRow< CustomTalk > CustomTalk;
        public LazyRow< Item > Item;
        public bool DestroyOnRemoval;
        public bool Unknown8;
        public bool Unknown9;
        public byte Unknown10;
        public byte Unknown11;
        public byte Unknown12;
        public bool Unknown13;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            ModelKey = parser.ReadColumn< byte >( 0 );
            HousingItemCategory = parser.ReadColumn< byte >( 1 );
            UsageType = parser.ReadColumn< byte >( 2 );
            UsageParameter = parser.ReadColumn< uint >( 3 );
            Unknown4 = parser.ReadColumn< byte >( 4 );
            CustomTalk = new LazyRow< CustomTalk >( lumina, parser.ReadColumn< uint >( 5 ), language );
            Item = new LazyRow< Item >( lumina, parser.ReadColumn< uint >( 6 ), language );
            DestroyOnRemoval = parser.ReadColumn< bool >( 7 );
            Unknown8 = parser.ReadColumn< bool >( 8 );
            Unknown9 = parser.ReadColumn< bool >( 9 );
            Unknown10 = parser.ReadColumn< byte >( 10 );
            Unknown11 = parser.ReadColumn< byte >( 11 );
            Unknown12 = parser.ReadColumn< byte >( 12 );
            Unknown13 = parser.ReadColumn< bool >( 13 );
        }
    }
}