// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HugeCraftworksRank", columnHash: 0xf7af7ac5 )]
    public partial class HugeCraftworksRank : ExcelRow
    {
        
        public byte CrafterLevel { get; set; }
        public uint ExpRewardPerItem { get; set; }
        public byte Unknown2 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            CrafterLevel = parser.ReadColumn< byte >( 0 );
            ExpRewardPerItem = parser.ReadColumn< uint >( 1 );
            Unknown2 = parser.ReadColumn< byte >( 2 );
        }
    }
}