// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CollectablesShopRewardItem", columnHash: 0xf7e08b71 )]
    public class CollectablesShopRewardItem : IExcelRow
    {
        
        public LazyRow< Item > Item;
        public bool Unknown1;
        public byte Unknown2;
        public byte Unknown3;
        public byte Unknown4;
        public uint Unknown5;
        public bool Unknown6;
        public byte Unknown7;
        public byte Unknown8;
        public byte Unknown9;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Item = new LazyRow< Item >( lumina, parser.ReadColumn< uint >( 0 ), language );
            Unknown1 = parser.ReadColumn< bool >( 1 );
            Unknown2 = parser.ReadColumn< byte >( 2 );
            Unknown3 = parser.ReadColumn< byte >( 3 );
            Unknown4 = parser.ReadColumn< byte >( 4 );
            Unknown5 = parser.ReadColumn< uint >( 5 );
            Unknown6 = parser.ReadColumn< bool >( 6 );
            Unknown7 = parser.ReadColumn< byte >( 7 );
            Unknown8 = parser.ReadColumn< byte >( 8 );
            Unknown9 = parser.ReadColumn< byte >( 9 );
        }
    }
}