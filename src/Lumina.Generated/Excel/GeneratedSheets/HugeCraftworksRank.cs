using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HugeCraftworksRank", columnHash: 0xf7af7ac5 )]
    public class HugeCraftworksRank : IExcelRow
    {
        
        public byte CrafterLevel;
        public uint ExpRewardPerItem;
        public byte Unknown2;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            CrafterLevel = parser.ReadColumn< byte >( 0 );
            ExpRewardPerItem = parser.ReadColumn< uint >( 1 );
            Unknown2 = parser.ReadColumn< byte >( 2 );
        }
    }
}