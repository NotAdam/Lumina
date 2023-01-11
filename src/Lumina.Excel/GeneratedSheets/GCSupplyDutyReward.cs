// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GCSupplyDutyReward", columnHash: 0x6be0e840 )]
    public partial class GCSupplyDutyReward : ExcelRow
    {
        
        public uint ExperienceSupply { get; set; }
        public uint ExperienceProvisioning { get; set; }
        public uint SealsExpertDelivery { get; set; }
        public uint SealsSupply { get; set; }
        public uint SealsProvisioning { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            ExperienceSupply = parser.ReadColumn< uint >( 0 );
            ExperienceProvisioning = parser.ReadColumn< uint >( 1 );
            SealsExpertDelivery = parser.ReadColumn< uint >( 2 );
            SealsSupply = parser.ReadColumn< uint >( 3 );
            SealsProvisioning = parser.ReadColumn< uint >( 4 );
        }
    }
}